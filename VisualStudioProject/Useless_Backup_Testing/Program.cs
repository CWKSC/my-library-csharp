using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.Math;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;
using Useless_Backup_Testing.Math;

namespace Useless_Backup_Testing
{
    class Program
    {


        public static void Main(string[] args)
        {
            string source =
@"boo x y .
foo . 2 .
    x + y .
emptythenexpend arg .
    ifEmpty args 123 .
// until \n args .  ";

            Compiler compiler = new Compiler();

            compiler.Compile(source);
            List<Token> tokenList = compiler.tokenList;
            //Token[] tokens = tokenList.ToArray().Loop((token, i) => (token.body, token.line).Println());

            compiler.GetStartTokenUntilEnd(0).ToArray().Loop((token, i) => (token.body, token.line).Println());

            //PowerX.Test();
        }

    }

}
