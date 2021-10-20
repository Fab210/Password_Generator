using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCS
{
    static class outils
    {
        public static int responseInt = 0;
        //static int askedNumber;
        public static int AskPositivNumberNotNull(string question)
        {
            if (responseInt < 0)
            {
                Console.WriteLine("Erreur selectionner un nombre POSITIF");
                responseInt = AskNumber(question);
            }

            return responseInt;

        }

        public static int AskNumberBetween(string question, int min, int max)
        {
            int askedNumber = AskNumber(question);


            while ((askedNumber < min) || (askedNumber > max))
            {
                Console.WriteLine("Erreur selectionner un nombre entre " + min + " et " + max);
                askedNumber = AskNumber(question);

            }
            return askedNumber;
        }

        public static int AskNumber(string question)
        {
            bool check = true;
            int notnull = 0;


            while (check == true)
            {
                Console.Write(question);
                string res = Console.ReadLine();

                try
                {
                    responseInt = int.Parse(res);
                    notnull = AskPositivNumberNotNull(question);

                    check = false;
                }
                catch
                {

                    Console.WriteLine("Select a number");
                }

            }
            return notnull;
        }
    }
}
