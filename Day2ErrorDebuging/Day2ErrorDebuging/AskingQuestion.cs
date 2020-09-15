using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class AskingQuestion
    {
        public string asking(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public int askingint(string question)
        {
            try
            {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error you put incorect input, please try again");
                return 3;
            }
            
        }
    }
}
