using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04_CountLetters
{
    public class CountLetters
    {
        public Dictionary<char, int> CountLetter(string text1)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            char[] array = text1.ToCharArray();
            Array.Sort(array);
            for(int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if (!map.ContainsKey(array[i]))
                {
                    map.Add(array[i], counter);
                }                
            }
            return map;
        }
    }
}
