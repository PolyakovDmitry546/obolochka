using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    static class Elements
    {
        public static List<Rule> Rules { get; } = new List<Rule>();

        public static List<Variable> Variables { get; } = new List<Variable>();

        public static List<Domain> Domains { get; } = new List<Domain>();

        public static bool CheckDomain(string name)
        {
            foreach (var domain in Domains)
                if (name == domain.Name)
                    return true;
            return false;
        }

        public static bool CheckDomain(string name, Domain currentDomain)
        {
            foreach (var domain in Domains)
                if (name == domain.Name && domain != currentDomain)
                    return true;
            return false;
        }

        public static bool CheckVariableName(string name, Variable currentVariable)
        {
            foreach (var variable in Variables)
                if (name == variable.Name && variable != currentVariable)
                    return true;
            return false;
        }

        public static bool CheckRuleName(string name, Rule currentRule)
        {
            foreach (var rule in Rules)
                if (name == rule.Name && rule != currentRule)
                    return true;
            return false;
        }

        public static Domain DomainFindByName(string name)
        {
            foreach (var domain in Domains)
                if (name == domain.Name)
                    return domain;
            return null;
        }

        public static Variable VariableFindByName(string name)
        {
            foreach (var variable in Variables)
                if (name == variable.Name)
                    return variable;
            return null;
        }
    }
}
