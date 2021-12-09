using System;
using System.Collections.Generic;
using System.Text;

namespace learn_English
{
    public class Paragraph : EnglishConstruct
    {
        private int numOfSentences;

        public int NumOfSentences { get{ return numOfSentences; } set{ numOfSentences = value; } }
        private const ConsoleColor colour = ConsoleColor.Yellow;


        public Paragraph(string Content) : base(Content)
        {
            foreach (char C in Content)
            {
                if (C == '.')
                {
                    NumOfSentences++;
                }
            }
        }


        public override void Recite()
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(Content);
            Console.WriteLine(NumOfSentences);
            Console.ForegroundColor = ConsoleColor.White;




        }


    }
}

