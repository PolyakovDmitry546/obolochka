using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    public class Rule
    {
        public string Name { get; set; }
        public string Clarification { get; set; }

        public List<Fact> Parcels { get; }
        public List<Fact> Conclusions { get; }

        public Rule()
        {
            Parcels = new List<Fact>();
            Conclusions = new List<Fact>();
        }

        public void AddParcel(Fact parcel)
        {
            Parcels.Add(parcel);
        }

        public void RemoveParcel(Fact parcel)
        {
            Parcels.Remove(parcel);
        }

        public void AddConclusion(Fact conclusion)
        {
            Conclusions.Add(conclusion);
        }

        public void RemoveConclusion(Fact conclusion)
        {
            Conclusions.Remove(conclusion);
        }
    }
}
