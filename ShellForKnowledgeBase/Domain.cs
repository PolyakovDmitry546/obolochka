using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    public class Domain
    {
        public string Name { get; set; }

        public List<string> Values { get; }

        public Domain()
        {
            Values = new List<string>();
        }

        public void AddValue(string value)
        {
            Values.Add(value);
        }

        public void RemoveValue(string value)
        {
            Values.Remove(value);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
