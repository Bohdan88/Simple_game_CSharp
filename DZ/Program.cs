using System;
using System.IO;

namespace IMJunior
{
    class Program
    {
        static int age = 0, strength = 0, agility = 0, intelligence = 0, points = 25;
        static string strengthVisual = string.Empty, agilityVisual = string.Empty, intelligenceVisual = string.Empty;


       
        static int[] Reverse(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[numbers.Length - i - 1];
            }
            return result;
        }


        static int Points()
        {
          
            string jeka = string.Empty;
            int row;

            do
            {
                jeka = Console.ReadLine();
            }
            while (!int.TryParse(jeka, out row));

            return row;

        }

        static void Charik(string makintosh, int operandPoints, int featerus)
        {
            if ( makintosh == "+")
            {
                int overhead = operandPoints - (10 - featerus);
                overhead = overhead < 0 ? 0 : overhead;
                operandPoints -= overhead;
            }
            else
            {
                int overhead = featerus - operandPoints;
                overhead = overhead < 0 ? overhead : 0;
                operandPoints += overhead;

            }
            featerus = makintosh == "+" ? featerus + operandPoints : featerus - operandPoints;
            points = makintosh == "+" ? points - operandPoints : points + operandPoints;

        }

        static void Main(string[] args)
        {

           


   Console.WriteLine("WELCOME!");
   Console.WriteLine("You have 25 points, which you can divide as you wish");
   Console.WriteLine("Press any key to continue");
   Console.ReadKey();


   while (points > 0)
   {
       Console.Clear();

                strengthVisual = string.Empty;
                agilityVisual = string.Empty;
                intelligenceVisual = string.Empty;
                strengthVisual = strengthVisual.PadLeft(strength, '#').PadRight(10, '_');
                agilityVisual = agilityVisual.PadLeft(agility, '#').PadRight(10, '_');
                intelligenceVisual = intelligenceVisual.PadLeft(intelligence, '#').PadRight(10, '_');

                Console.WriteLine("Points - {0}", points);
      Console.WriteLine("Age - {0}\nStrength - [{1}]\nAgility - [{2}]\nIntelligence - [{3}]", age, strengthVisual, agilityVisual, intelligenceVisual);

       Console.WriteLine("Which feature do you wanna to change?");
       string subject = Console.ReadLine();

       Console.WriteLine(@"What do you want to implement? +\-");
    string operation = Console.ReadLine();

       Console.WriteLine(@"The number of points {0}", operation == "+" ? "add" : "take away");

              

                 int operandPoints = Points();


                switch (subject.ToLower())
       {
           case "strength":
                        Charik("+", operandPoints, strength);
                        break;
                    case "agility":
                        Charik("+", operandPoints, agility);
                        break;
                        
           case "intelligence":
                        Charik("+", operandPoints, intelligence);
                        break;
                }
   }

   Console.WriteLine("\n You have distributed all the points. Write character's age\n");
           
  
            age = Points();


            Console.ReadLine();
            Console.Clear();
            strengthVisual = string.Empty;
            agilityVisual = string.Empty;
            intelligenceVisual = string.Empty;
            strengthVisual = strengthVisual.PadLeft(strength, '#').PadRight(10, '_');
            agilityVisual = agilityVisual.PadLeft(agility, '#').PadRight(10, '_');
            intelligenceVisual = intelligenceVisual.PadLeft(intelligence, '#').PadRight(10, '_');
            Console.WriteLine("Age - {0}\nStrength - [{1}]\nagility - [{2}]\nIntelligence - [{3}]", age, strengthVisual, agilityVisual, intelligenceVisual);

     }


    }
}