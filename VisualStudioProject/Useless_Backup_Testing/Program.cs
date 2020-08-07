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

        public enum TokenType
        {
            Symbol, End
        }

        public class Token
        {
            public TokenType tokenType;
            public string body;
            public int line;


            public Token(string body, int line, TokenType tokenType = TokenType.Symbol)
            {
                this.tokenType = tokenType;
                this.body = body;
                this.line = line;
            }
        }




        public static List<Token> LineTokenize(string source, int lineCount)
        {
            List<Token> result = new List<Token>();
            string[] tokens = source.TrimStart(' ').Split(' ');
            for (int i = 0; i < tokens.Length; i++)
            {
                //tokens[i].Println();
                result.Add(new Token(tokens[i], lineCount));
            }
            return result;
        }

        public static List<Token> Tokenize(string source)
        {
            List<Token> result = new List<Token>();
            string[] lineSource = source.Split("\r\n");
            for (int i = 0; i < lineSource.Length; i++)
            {
                //lineSource[i].Println();
                result.AddRange(LineTokenize(lineSource[i], i));
            }
            return result;
        }

        public static void Main(string[] args)
        {
            string source = 
@"foo . 2 .
boo x y .
    x + y .
emptythenexpend arg .
    ifEmpty args 123 .";

            List<Token> tokenList = Tokenize(source);
            Token[] tokens = tokenList.ToArray().Loop((token, i) => (token.body, token.line).Println());
            string marcoName = tokenList[0].body;
            
            //PowerX.Test();
        }

    }

}
