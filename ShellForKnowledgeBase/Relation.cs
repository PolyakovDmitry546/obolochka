using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    public class Relation
    {
        public enum Relations { Equally, NotEqual }

        public Relations Value { get; set; }

        public override string ToString()
        {
            if (Value == Relations.Equally)
                return "=";
            else
                return "!=";
        }
    }
}
