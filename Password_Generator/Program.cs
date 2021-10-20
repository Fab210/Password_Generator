using FormationCS;
using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // NUMBER OFF PASSWORD THAT YOU WANT TO GENERATE
            const int NB_OF_PASSWORD = 10;

            // VARIABLES
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string upperLetters = letters.ToUpper();
            string numbers = "0123456789";
            string specialchar = "+-*/.";
            string abc = "";

            // ASK PASSWORD LENGTH
            int askedNumber = outils.AskNumberBetween("Longueur du mot de passe :", 1, 10);

            // ASK TYPE OF PASSWORD
            int typeOfPass = outils.AskNumberBetween("Vous voulez un mot de passe avec \n" +
              "1 - Uniquement des caracters minuscule \n" +
              "2 - Majuscules et Minuscules \n" +
              "3 - Caracteres et chiffres \n" +
              "4 - Caracteres , chiffres et caracteres speciaux \n", 1, 4);

            // SWITCH TYPE OF PASSWORD
            switch (typeOfPass)
            {
                case 1:
                    abc = letters;
                    break;
                case 2:
                    abc = letters + upperLetters;
                    break;
                case 3:
                    abc = numbers + specialchar;
                    break;
                case 4:
                    abc = letters + upperLetters + numbers + specialchar;
                    break;
                default:
                    break;
            }

            // COUNT PASSWORD LENGTH
            int abcLength = abc.Length;

            // INITIALIZE RANDOM INSTANCE
            Random rand = new Random();

            // GENERATE RANDOM PASSWORDS
            for (int i = 0; i < NB_OF_PASSWORD + 1; i++)
            {
                string password = "";
                for (int j = 0; j < askedNumber; j++)
                {

                    int index = rand.Next(0, abcLength);
                    password = password + abc[index];


                }
                Console.WriteLine("PASSWORD --> " + password);
            }
        }
    }
}
