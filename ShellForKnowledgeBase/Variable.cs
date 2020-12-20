using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    public class Variable
    {
        public enum VariableType { Deduce, Requested }

        public string Name { get; set; }

        public Domain Domain { get; set; }

        public VariableType Type { get; set; }

        public string Question { get; set; }

        public Variable()
        {

        }

        public Variable(string name, Domain domain, VariableType type, string question)
        {
            Name = name;
            Domain = domain;
            Type = type;
            Question = question;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
