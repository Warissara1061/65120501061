using System;

    namespace test165120501061{
        class Program {
        static void Main(string[] args) {
                Console.Write("Day of week: ");
                int Day = int.Parse(Console.ReadLine());
                int Monday = 1;
                int Tuseday = 2;
                int Wednesday = 3;
                int Thrusday = 4;
                int Friday = 5;
                int Saturday = 6;
                int Sunday = 7;
              
                Console.Write("Time of day: ");
                int time = 0;     
                   
                Console.Write("Input Menu: ");
                string y = (Console.ReadLine());
                string y1 = "Breakfast Set";
                string y2 = "Weekend Set";
                string y3 = "Coffee";

                Console.Write("Input number: ");             
                int x1 = 5;
                int x2 = 2;
                int x3 = 3;


            switch (y){
                case "Breakfast":
                if (y1 == "Breakfast"){
                Console.WriteLine("Input num: ");
               } else if (x1 == 0){
                    Console.WriteLine("Sorry your order is out of stock");
               } else if (time >= 11){
                Console.WriteLine("Sorry your order is not available");
               } else {
                Console.WriteLine("Please Try Again");
               }
               break;
                case "Weekend":
                if (y2 == "Weekend"){
                Console.WriteLine("Input num: ");
               } else if (x2 == 0 && x2 < 3){
                Console.WriteLine("Sorry your order is out of stock");
               } else if (Monday == 1 && Tuseday == 2 && Wednesday == 3 && Thrusday == 4 && Friday == 5){
                Console.WriteLine("Please enter a valid menu");
               }                
               break;
               case "Coffee":
               if (y3 == "Coffee"){
                Console.WriteLine("Input num: ");
               } else if (x3 == 0 && x3 < 4){
                Console.WriteLine("Sorry your order is out of stock");
            }
               break;
               default: 
               Console.WriteLine("Please enter a valid menu");
                break;
               }
              }
                        }
                    }              
