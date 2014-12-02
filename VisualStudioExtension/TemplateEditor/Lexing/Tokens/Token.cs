﻿using System;
using Typewriter.TemplateEditor.Lexing.Contexts;

namespace Typewriter.TemplateEditor.Lexing.Tokens
{
    public class Token
    {
        public Token(int start, int length, TokenType type, IContext context, string quickInfo = null, Token matchingToken = null)
        {
            Start = start;
            End = start + length;
            Length = length;
            Type = type;
            Context = context;
            QuickInfo = quickInfo;
            MatchingToken = matchingToken;

            switch (type)
            {
                case TokenType.Comment:
                    Classification = Classifications.Comment;
                    break;

                case TokenType.Keyword:
                    Classification = Classifications.Keyword;
                    break;

                case TokenType.Identifier:
                    Classification = Classifications.Property;
                    break;
            }
        }

        public TokenType Type { get; private set; }
        public IContext Context { get; private set; }
        public string Classification { get; set; }
        public string QuickInfo { get; private set; }
        public Token MatchingToken { get; set; }
        public int Start { get; private set; }
        public int End { get; private set; }
        public int Length { get; private set; }
    }
}