using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{

    public class Condition
    {
        public string name;
        public Func<bool> condition;
    }

    public class Conclusions
    {

    }

    public class Rule
    {
        public Condition If;
        public Condition Then;
    }

    public partial class RuleBasedSystem
    {
        public List<Rule> rules = new List<Rule>();



    }


}
