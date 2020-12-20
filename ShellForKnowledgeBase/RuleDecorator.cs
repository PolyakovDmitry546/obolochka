using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    public static class RuleDecorator
    {
        public static string GetRuleDescription(Rule rule)
        {
            StringBuilder description = new StringBuilder("ЕСЛИ", 128);
            foreach(var parcel in rule.Parcels)
            {
                description.Append($" {parcel.Variable.Name}{parcel.Relation.ToString()}{parcel.Value} И");
            }
            description.Remove(description.Length - 1, 1);
            description.Append(" ТО");
            foreach(var conclusion in rule.Conclusions)
            {
                description.Append($" {conclusion.Variable.Name}{conclusion.Relation.ToString()}{conclusion.Value} И");
            }
            description.Remove(description.Length - 1, 1);
            return description.ToString();
        }
    }
}
