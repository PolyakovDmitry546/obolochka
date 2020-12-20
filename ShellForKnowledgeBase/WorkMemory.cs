using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellForKnowledgeBase
{
    class RuleTree
    {
        public Fact goal;
        public Rule rule;
        public Rule parent;
        public List<RuleTree> childs;

        public RuleTree()
        {
            childs = new List<RuleTree>();
        }
    }

    static class WorkMemory
    {
        public static RuleTree ruleTree;
        public static List<Fact> requestedFacts;
    }
}
