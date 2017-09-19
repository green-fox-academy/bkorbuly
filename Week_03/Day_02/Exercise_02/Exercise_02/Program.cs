using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                using (StreamReader reader = new StreamReader("C:/Users/Balazs/Greenfox/Week_03/Day_02/my_file.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("{0}", e);
            }

                Console.ReadLine();
        }
    }
}
