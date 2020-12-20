using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    static class FileManager
    {
        public static void Save(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, append: false)) 
            {
                outputFile.WriteLine("Domains: [");
                foreach (var domain in Elements.Domains)
                {
                    outputFile.WriteLine("Domain: {");
                    outputFile.WriteLine("Name: " + domain.Name + ",");
                    outputFile.WriteLine("Values: [");
                    foreach (var value in domain.Values)
                    {
                        outputFile.WriteLine(value + ",");
                    }
                    outputFile.WriteLine("],");
                    outputFile.WriteLine("},");
                }
                outputFile.WriteLine("],");

                outputFile.WriteLine("Variables: [");
                foreach (var variable in Elements.Variables)
                {
                    outputFile.WriteLine("Variable: {");
                    outputFile.WriteLine("Name: " + variable.Name + ",");
                    outputFile.WriteLine("Type: " + variable.Type.ToString() + ",");
                    outputFile.WriteLine("Domain: " + variable.Domain.Name + ",");
                    outputFile.WriteLine("Question: " + variable.Question + ",");
                    outputFile.WriteLine("},");
                }
                outputFile.WriteLine("],");

                outputFile.WriteLine("Rules: [");
                foreach (var rule in Elements.Rules)
                {
                    outputFile.WriteLine("Rule: {");
                    outputFile.WriteLine("Name: " + rule.Name + ",");
                    outputFile.WriteLine("Parcels: [");
                    foreach (var parcel in rule.Parcels)
                    {
                        outputFile.WriteLine("Variable: " + parcel.Variable.Name + ",");
                        outputFile.WriteLine("Relation: " + parcel.Relation + ",");
                        outputFile.WriteLine("Value: " + parcel.Value + ",");
                    }
                    outputFile.WriteLine("],");
                    outputFile.WriteLine("Conclusions: [");
                    foreach (var couclusion in rule.Conclusions)
                    {
                        outputFile.WriteLine("Variable: " + couclusion.Variable.Name + ",");
                        outputFile.WriteLine("Relation: " + couclusion.Relation + ",");
                        outputFile.WriteLine("Value: " + couclusion.Value + ",");
                    }
                    outputFile.WriteLine("],");
                    outputFile.WriteLine("Reason: " + rule.Clarification + ",");
                    outputFile.WriteLine("},");
                }
                outputFile.WriteLine("],");
            }
        }

        public static void Open(string fileName)
        {
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                Elements.Domains.Clear();
                Elements.Variables.Clear();
                Elements.Rules.Clear();

                int state = 0;
                string str;
                Domain domain = null;
                Variable variable = null;
                Rule rule = null;
                Fact fact = null;

                while ((str = inputFile.ReadLine()) != null)
                {
                    #region Domain
                    if (str.Contains("Domains: ["))
                    {
                        state = 1;
                    }
                    if(state == 1 && str.Contains("Domain: {"))
                    {
                        state = 11;
                        domain = new Domain();
                    }
                    if (state == 11 && str.Contains("Name:"))
                    {
                        var s = str.Replace("Name:", "").Trim(new char[] { ' ', ',' });
                        domain.Name = s;
                    }
                    if (state == 11 && str.Contains("Values:"))
                    {
                        state = 12;
                        continue;
                    }
                    if (state == 12 && str.Contains("],"))
                    {
                        state = 11;
                    }
                    if (state == 12)
                    {
                        domain.Values.Add(str.Trim(new char[] { ' ', ',' }));
                    }
                    if (state == 11 && str.Contains("},"))
                    {
                        state = 1;
                        Elements.Domains.Add(domain);
                    }
                    if (state == 1 && str.Contains("],"))
                    {
                        state = 0;
                    }
                    #endregion

                    #region Variable
                    if (str.Contains("Variables: ["))
                    {
                        state = 2;
                    }
                    if (state == 2 && str.Contains("Variable: {"))
                    {
                        state = 21;
                        variable = new Variable();
                    }
                    if (state == 21 && str.Contains("Name:"))
                    {
                        var s = str.Replace("Name:", "").Trim(new char[] { ' ', ',' });
                        variable.Name = s;
                    }
                    if (state == 21 && str.Contains("Type:"))
                    {
                        var s = str.Replace("Type:", "").Trim(new char[] { ' ', ',' });
                        if (s == "Deduce")
                            variable.Type = Variable.VariableType.Deduce;
                        else
                            variable.Type = Variable.VariableType.Requested;
                    }
                    if (state == 21 && str.Contains("Domain:"))
                    {
                        var s = str.Replace("Domain:", "").Trim(new char[] { ' ', ',' });
                        variable.Domain = Elements.DomainFindByName(s);
                    }
                    if (state == 21 && str.Contains("Question:"))
                    {
                        var s = str.Replace("Question:", "").Trim(new char[] { ' ', ',' });
                        variable.Question = s;
                    }
                    if (state == 21 && str.Contains("},"))
                    {
                        state = 2;
                        Elements.Variables.Add(variable);
                    }
                    if (state == 2 && str.Contains("],"))
                    {
                        state = 0;
                    }
                    #endregion

                    #region Rule
                    if (str.Contains("Rules: ["))
                    {
                        state = 3;
                    }
                    if (state == 3 && str.Contains("Rule: {"))
                    {
                        state = 31;
                        rule = new Rule();
                    }
                    else if (state == 31 && str.Contains("Name:"))
                    {
                        var s = str.Replace("Name:", "").Trim(new char[] { ' ', ',' });
                        rule.Name = s;
                    }
                    if (state == 31 && str.Contains("Parcels: ["))
                    {
                        state = 32;
                    }
                    if (state == 32 && str.Contains("Variable:"))
                    {
                        var s = str.Replace("Variable: ", "").Trim(new char[] { ' ', ',' });
                        var vr = Elements.VariableFindByName(s);

                        if (vr != null)
                        {
                            fact = new Fact();
                            fact.Variable = vr;
                        }
                    }
                    if (state == 32 && str.Contains("Relation:"))
                    {
                        var s = str.Replace("Relation: ", "").Trim(new char[] { ' ', ',' });
                        var rel = new Relation();
                        if (s == "=")
                            rel.Value = Relation.Relations.Equally;
                        else
                            rel.Value = Relation.Relations.NotEqual;
                        fact.Relation = rel;
                    }
                    if (state == 32 && str.Contains("Value:"))
                    {
                        var s = str.Replace("Value: ", "").Trim(new char[] { ' ', ',' });
                        fact.Value = s;
                    }
                    if (state == 32 && str.Contains("],"))
                    {
                        state = 31;
                        rule.Parcels.Add(fact);
                    }
                    if (state == 31 && str.Contains("Conclusions: ["))
                    {
                        state = 33;
                    }
                    if (state == 33 && str.Contains("Variable:"))
                    {
                        var s = str.Replace("Variable: ", "").Trim(new char[] { ' ', ',' });
                        var vr = Elements.VariableFindByName(s);

                        if (vr != null)
                        {
                            fact = new Fact();
                            fact.Variable = vr;
                        }
                    }
                    if (state == 33 && str.Contains("Relation:"))
                    {
                        var s = str.Replace("Relation: ", "").Trim(new char[] { ' ', ',' });
                        var rel = new Relation();
                        if (s == "=")
                            rel.Value = Relation.Relations.Equally;
                        else
                            rel.Value = Relation.Relations.NotEqual;
                        fact.Relation = rel;
                    }
                    if (state == 33 && str.Contains("Value:"))
                    {
                        var s = str.Replace("Value: ", "").Trim(new char[] { ' ', ',' });
                        fact.Value = s;
                    }
                    if (state == 33 && str.Contains("],"))
                    {
                        state = 31;
                        rule.Conclusions.Add(fact);
                    }
                    if (state == 31 && str.Contains("Reason:"))
                    {
                        var s = str.Replace("Reason:", "").Trim(new char[] { ' ', ',' });
                        rule.Clarification = s;
                    }
                    if (state == 31 && str.Contains("},"))
                    {
                        state = 3;
                        Elements.Rules.Add(rule);
                    }
                    if (state == 3 && str.Contains("],"))
                    {
                        state = 0;
                    }
                    #endregion
                }
            }
        }
    }
}
