using System;
using System.Collections.Generic;

namespace Exercise_03_Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            var dominotemp = new Domino(0, 0);
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            foreach (Domino domino in dominoes)
            {
                Console.WriteLine("[{0}, {1}]",domino.GetValues()[0], domino.GetValues()[1]);
            }
            //for (int i = 0; i < dominoes.Count - 1; i++)
            //{
            //    for (int j = 0; j < dominoes.Count ; j++)
            //    {              
            //        if (dominoes[i].GetValues()[1] == dominoes[j].GetValues()[0])
            //        {
            //            //dominotemp = dominoes[i + 1];
            //            dominoes.Insert(i + 1, dominoes[j]);
            //            dominoes.RemoveAt(j + 1);
            //            //dominoes.RemoveAt(dominoes.Count - 1);

            //            //Console.WriteLine("//////////////////////////////////////////////");

            //            //Console.WriteLine("[{0}, {1}]", dominoes[i].GetValues()[0], dominoes[i].GetValues()[1]);
            //            //Console.WriteLine("[{0}, {1}]", dominoes[j].GetValues()[0], dominoes[j].GetValues()[1]);
            //        }
            //    }
            //}
            Console.WriteLine("");
            dominoes.Sort();
            foreach (Domino domino in dominoes)
            {
                Console.Write("[{0}, {1}]", domino.GetValues()[0], domino.GetValues()[1]);
            }
            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}