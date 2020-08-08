using System;
using System.Collections.Generic;
using System.Text;

namespace Useless_Backup_Testing
{
    public class Compiler
    {

        public List<Token> tokenList = new List<Token>();

        private void LineTokenize(string source, int lineCount)
        {
            string[] tokens = source.TrimStart(' ').Split(' ');
            for (int i = 0; i < tokens.Length; i++)
                tokenList.Add(new Token(tokens[i], lineCount));
        }

        private void Tokenize(string source)
        {
            string[] lineSource = source.Split("\r\n");
            for (int i = 0; i < lineSource.Length; i++)
                LineTokenize(lineSource[i], i);
        }

        public List<Token> GetStartTokenUntilEnd(int index)
        {
            List<Token> tokenSeq = new List<Token>();
            index += 1;
            while (index != tokenList.Count && tokenList[index].body != ".")
            {
                tokenSeq.Add(tokenList[index]);
                index++;
            }
            return tokenSeq;
        }

        public void Compile(string source)
        {
            Tokenize(source);
        }


    }
}
