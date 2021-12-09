using System;
using System.Collections.Generic;
using System.Text;

namespace learn_English
{
    public class Sentence : EnglishConstruct
    {

        private int numOfWords ;
        public int NumOfWords{ get {return numOfWords; } set { numOfWords = value; } }
        private const ConsoleColor colour = ConsoleColor.Green;


        public Sentence(string Content) : base(Content)
        {

            foreach (char C in Content)
            {
                if (char.IsWhiteSpace(C))
                {
                    NumOfWords++;
                }     
            }  
              NumOfWords++; //to add the last word as it does not finish with space
        }

        public override void Recite()
        {
            if (NumOfWords == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lorem Ipsum.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {
                Console.ForegroundColor = colour;
                Console.WriteLine(Content);
                Console.WriteLine(NumOfWords);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

    }
}


