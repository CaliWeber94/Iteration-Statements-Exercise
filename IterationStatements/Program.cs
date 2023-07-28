using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below


        //Write a method that will print to the console all numbers 1000 through - 1000 DONE***
         public static void PrintNums1000()
        {
            for(int i = 1000; i>=-1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThrees()
        {
            for (int i = 3; i<=999; i+=3)
            {
                Console.Write(i);
            }
            
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not 
        public static bool TwoNumsSame(int x, int y)
        {
            if (x == y)
            {
                return true;

            }

            else
             {return false; }
            
             
            
            
        }
        
        //Write a method to check whether a given number is even or odd 
         public static void EvenOrOdd(int num)
        {
            if(num % 2 == 0)
                Console.WriteLine("even");
            else { Console.WriteLine("odd"); }
        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num)
        {
            if (num > 0)
                return true;
            else { return false; } }
        //Write a method to read the age of a candidate and determine whether they can vote. 
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
            public static bool CanVote()
        {
            Console.WriteLine("Please enter your age");
            var canParse = int.TryParse(Console.ReadLine(), out int age);
            while(canParse==false) 
            {
                Console.WriteLine("please enter a valid age");
                canParse = int.TryParse(Console.ReadLine(),out age);

            }
            if(age>=18)
            {
                return true;
              
            }else return false;
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsItInRange(int num)
        {
            if (num <=10 && num >= -10)
            {
                return true;

            }
            else { return false; }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
            public static void MultiplyThru12(int num)
        {
             for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num}*{i}");   
            }
                
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNums1000();
            UpByThrees();
            TwoNumsSame(2, 3);
            EvenOrOdd(5);
            IsPositive(8);
            CanVote();
            IsItInRange(9);
            MultiplyThru12(12);



                       
            
            
            
             
            
                      

            
            
           

            
           
            
                
                
            
                
                

            
            
            
                

            

            
           
            
            

            
            
            
              
            

            
            
                

            
        }
    }
}
