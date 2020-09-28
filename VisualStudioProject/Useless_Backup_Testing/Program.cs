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
@"
foo 2 .

boo 
    tokens 1 x
    tokens 2 y
    x + y
.

ifEmpty 
    tokens 1 token
    until . content
    if token  content
.

// until \n args .

/* until */ args .

foo . 2 .
boo 
    index token 0 x 
    index token 1 y 
    . 
    x + y .
ifEmpty 
    token expand 
    .
    if eq token  expand .

emptythenexpend123 args .
    ifEmpty args 123 .

// until \n args . .

def until token . .

def def 
    until . rules 
    until . expends
    .
    getTokenByRule rules 
        replance expends token 
        expandToken expends 
";

            Compiler compiler = new Compiler();

            compiler.Compile(source);
            List<Token> tokenList = compiler.tokenList;
            Token[] tokens = tokenList.ToArray().Loop((token, i) => (token.body, token.line).Println());

            //compiler.GetStartTokenUntilEnd(0).ToArray().Loop((token, i) => (token.body, token.line).Println());

            //PowerX.Test();
        }

    }



}
