using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = Add(5, 7);
            //Console.Write

            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Please enter your favorite food");
            // string food = Console.ReadLine();


            //FavoriteFood("Bob", "pizza");
            //FavoriteFood("Mia", "ice cream");
            //FavoriteFood("Beth", "apples");

            //RetirementCalc(70);


            Console.WriteLine("Please enter your hours worked this month");
            double worked = double.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your hourly wage");
            double wage = double.Parse(Console.ReadLine());



            Console.WriteLine("Your monthly wage is " + WageCalc(worked, wage)); 





        }


        //public static void FavoriteFood(string name, string food)
        //{
        //    Console.WriteLine("**************");
        //    Console.WriteLine(name + "'s favorite food is " + food);
        //    Console.WriteLine(); 
        //}

        //public static void RetirementCalc(int age)
        //{
        //    int retirementAge = Math.Max(0, 65 - age); 
        //    Console.WriteLine("The user will retire in " + retirementAge + " years"); 
        //}




        public static double WageCalc(double worked, double wage)
        {
            double moneyMade = (worked * wage);
            
            return moneyMade;
         
        } 

















        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;

        //    return sum; 
        //}





    }
}
