using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public class Rule
    {
        public List<Fact> Ifs = new List<Fact>();
        public List<Fact> Thens = new List<Fact>();
        public bool isFired = false;

        public Rule() { }
        public Rule(Fact If, Fact Then)
        {
            Ifs.Add(If);
            Thens.Add(Then);
        }
        public Rule((Fact, Fact) If, params Fact[] Then)
        {
            Ifs.AddRange(new Fact[] { If.Item1, If.Item2 });
            Thens.AddRange(Then);
        }
        public Rule((Fact, Fact, Fact) If, params Fact[] Then)
        {
            Ifs.AddRange(new Fact[] { If.Item1, If.Item2, If.Item3 });
            Thens.AddRange(Then);
        }
        public Rule((Fact, Fact, Fact, Fact) If, params Fact[] Then)
        {
            Ifs.AddRange(new Fact[] { If.Item1, If.Item2, If.Item3, If.Item4 });
            Thens.AddRange(Then);
        }
        public Rule((Fact, Fact, Fact, Fact, Fact) If, params Fact[] Then)
        {
            Ifs.AddRange(new Fact[] { If.Item1, If.Item2, If.Item3, If.Item4, If.Item5 });
            Thens.AddRange(Then);
        }


        public void AddIf(params Fact[] If) => Ifs.AddRange(If);
        public void AddThen(params Fact[] Then) => Thens.AddRange(Then);

        public bool CheckIf(List<Fact> facts) => !Ifs.Except(facts).Any();
        public bool CheckIf(params Fact[] facts) => !Ifs.Except(facts).Any();

        public bool CheckThen(List<Fact> facts) => !Thens.Except(facts).Any();
        public bool CheckThen(params Fact[] facts) => !Thens.Except(facts).Any();

        public void PrintIf()
        {
            if (Ifs.Count == 0) return;
            Ifs[0].Print();
            for (int i = 1; i < Ifs.Count; i++)
            {
                Console.Write(" & ");
                Ifs[i].Print();
            }
        }
        public void PrintThen()
        {
            if (Thens.Count == 0) return;
            Thens[0].Print();
            for (int i = 1; i < Thens.Count; i++)
            {
                Console.Write(" & ");
                Thens[i].Print();
            }
        }
    }

}
