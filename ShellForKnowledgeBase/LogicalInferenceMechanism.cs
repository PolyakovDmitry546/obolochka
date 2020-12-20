using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    static class LogicalInferenceMechanism
    {
        public static bool CompareFact(Fact fact1, Fact fact2)
        {
            if (fact1.Variable.Name != fact2.Variable.Name)
                return false;

            if (fact1.Value != fact2.Value)
                return false;

            return true;
        }


        public static Fact FindFactByName(string name, List<Fact> facts)
        {
            foreach(var fact in facts)
            {
                if (fact.Variable.Name == name)
                    return fact;
            }

            return null;
        }


        public static void ObrViv(RuleTree tree, List<Fact> workingFact)
        {
            var goal = tree.goal;
            if(goal.Variable.Type == Variable.VariableType.Requested)
            {
                var fact = FindFactByName(goal.Variable.Name, WorkMemory.requestedFacts);
                if(fact == null)
                {
                    fact = AskUser();
                    WorkMemory.requestedFacts.Add(fact);
                }
                if (CompareFact(fact, goal))
                {
                    //не удалось доказать цель
                    return;
                }
                else
                {
                    //цель доказана
                    return;
                }
            }

            var fact = FindFactByName(goal.Variable.Name, workingFact);
            if(fact != null)
            {
                if (CompareFact(fact, goal))
                {
                    //не удалось доказать цель
                    return;
                }
                else
                {
                    //цель доказана
                    return;
                }
            }
            else
            {
                //перебрать все еще не используемые правила
                foreach (var rule in Elements.Rules)
                {
                    if (!UsingRule(rule, tree))
                    {
                        if (CheckConclusion(rule, goal))
                        {
                            foreach (var parcel in rule.Parcels)
                            {
                                //вывод по новым целям
                                ObrViv(tree, workingFact);
                            }
                        }
                    }
                }
            }
        }

        public static Fact Init(Variable goal)
        {
            List<Fact> hipotises = new List<Fact>();

            foreach(var value in goal.Domain.Values)
            {
                var hipotis = new Fact();
                hipotis.Variable = goal;
                hipotis.Relation = new Relation();
                hipotis.Relation.Value = Relation.Relations.Equally;
                hipotis.Value = value;
            }

            WorkMemory.ruleTree = new RuleTree();

            foreach(var hipotis in hipotises)
            {
                var node = new RuleTree();
                node.goal = hipotis;

                var exe = CheckHipotis(hipotis);
                if (exe)
                    return hipotis;
            }
        }
    }
}
