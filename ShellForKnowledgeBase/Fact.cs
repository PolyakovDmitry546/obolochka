using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    public class Fact
    {
        public Variable Variable { get; set; }

        public Relation Relation { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return Variable.Name + Relation.ToString() + Value;
        }
    }
}
