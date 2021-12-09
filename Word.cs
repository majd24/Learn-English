using System;
using System.Collections.Generic;
using System.Text;

namespace learn_English
{
    public class Word : EnglishConstruct
    {

        private int numOfChars;
        public int NumOfChars { get{return numOfChars; } set { numOfChars = value; } }
        private const ConsoleColor colour = ConsoleColor.Blue;

         
      
        public Word(string Content) : base(Content)
        {
           


            foreach (char C in Content)
            {
                NumOfChars++;

            }

            
        }


        public override void Recite()
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(Content);
            Console.WriteLine(NumOfChars);
            Console.ForegroundColor = ConsoleColor.White;
         
        }

        

    }
}

