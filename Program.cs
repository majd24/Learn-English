using System;
using System.Collections.Generic;

namespace learn_English
{
    class Program
    {

        static List<EnglishConstruct> english = new List<EnglishConstruct>();
        
 
        static int MainMenu()
        {
            int result = 0;
            Console.Clear();
            Console.WriteLine("\nMain Menu\n----------");
            Console.WriteLine("1 - Add a word");
            Console.WriteLine("2 - Add a sentence");
            Console.WriteLine("3 - Add a paragraph");
            Console.WriteLine("4 - Recite all");
            Console.WriteLine("5 - Recite all valid");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("\n-----------------\nYour Choice: ");
            result = Convert.ToInt32(Console.ReadLine());
            return result;


        }


        static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = MainMenu();
                switch (choice)
                {
                    case 1: // Add a word
                        HndelAddWord();
                        break;
                    case 2: // Add a Sentence
                        HndelAddSentence();
                        break;
                    case 3: // Add a Paragraph
                        HndelAddParagraph();
                        break;
                    case 4: // Recite all
                        HndelReciteAll();
                        break;
                    case 5: // Recite valid
                        HndelReciteValid();
                        break;
                    case 6: //Exit 
                        Environment.Exit(0);     
                        break;
                    default://Invalid input
                        Console.WriteLine("You have Entered an Invalid input");
                        break;

                }
                Console.WriteLine("Press any key to return to Menu...");
                Console.ReadKey();
            } while (choice != 6);

        }

        

        public static void HndelAddWord()
        {
            Console.WriteLine("\n Enter a word");
            String word = Console.ReadLine();

            Word newWord = new Word(word);
            english.Add(newWord);
   

        }

        public static void HndelAddSentence()
        {
            Console.WriteLine("\n Enter a Sentence");
            String sentence = Console.ReadLine();

            Sentence newSentence = new Sentence(sentence);
            english.Add(newSentence);

        }

        public static void HndelAddParagraph()
        {
            Console.WriteLine("\n Enter a Paragraph");
            String paragraph = Console.ReadLine();

            Paragraph newParagraph = new Paragraph(paragraph);
            english.Add(newParagraph);

        }


        public static void HndelReciteAll()
        {
            english.ForEach(item => item.Recite());
            
        }


           public int Val;
        
        public static void HndelReciteValid()
         {
          
            foreach (EnglishConstruct item in english)
            {
                if (item.Validation == true)
                {
                    english.ForEach(item => item.Recite());
                }                    
            }
            
         
        }

    }
}

