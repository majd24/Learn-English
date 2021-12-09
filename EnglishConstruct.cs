using System;
using System.Collections.Generic;
using System.Text;

namespace learn_English
{
	public class EnglishConstruct
    {

		private bool validation;
		private string content;
		public string Content { get{ return content; } set{ content = value; } }
		public  bool Validation { get { return validation; } set{ validation = value; } }




		public EnglishConstruct(string Content)

		{
			Char s1 = '#';
			Char s2 = '*';
            if (Content.Contains(s1) || Content.Contains(s2))
			{

				Validation = false;


			}

			else
			{

				Validation = true;

            }
             
			
  }
		


		public virtual void Recite()
		{

		}


	}
}
