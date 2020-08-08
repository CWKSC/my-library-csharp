using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Useless_Backup_Testing
{
    public class KeyWord
    {
        public static readonly string Until = "until";
        public static readonly string EndSymbol = ".";
        public static readonly string Va_args = "va_args";
        public static readonly string UntilEnd = "untilEnd";
    }

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

}
