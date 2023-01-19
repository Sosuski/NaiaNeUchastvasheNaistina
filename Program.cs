using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        class Food
        {
            public Food(string name, int calories)
            {
                this.name = name;
                this.calories = calories;
            }
            string name;
            int calories;

            public string getName()
            {
                return name;
            }

            public int getCalories()
            {
                return calories;
            }
        }

        static string[] meal = new string[] { "Breakfast", "Lunch", "Dinner" };

        static List<List<Food>> foods = new List<List<Food>>();
        static int days = 0;

        static int maxCalorie = 0, minCalorie = 0;
        void CalculateNewDay()
        {
            
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Maximum calorie intake");
            maxCalorie = int.Parse(Console.ReadLine());

            Console.WriteLine("Minimum calorie intake");
            minCalorie = int.Parse(Console.ReadLine());

            while(true)
            {
                Console.WriteLine($"You're at your {days} day");
                List<Food> q = new List<Food>();


                for (int i = 0; i < 3; i++)
                {
                    string name;
                    Console.WriteLine($"What did you eat for {meal[i]}");

                    name = Console.ReadLine();

                    Console.WriteLine("How many calories it was?");
                    int calories = int.Parse(Console.ReadLine());

                    q.Add(new Food(name, calories));
                }
                int totalCalories = 0;

                for(int i = 0; i < 3; i++)
                {
                    totalCalories += q[i].getCalories(); //asdasdas
                }

                if(minCalorie < totalCalories && totalCalories < maxCalorie)
                {
                    Console.WriteLine("Great work !");
                } else if(totalCalories < minCalorie)
                {
                    Console.WriteLine($"You need to eat {minCalorie - totalCalories} more calories");
                } else
                {
                    Console.WriteLine($"You had to eat {totalCalories - maxCalorie} less calories");
                }
                foods.Add(q);

                days++;
                Console.WriteLine("Ivelin");
            }
        }
    }
}
