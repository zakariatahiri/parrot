using System;
using System.Data;
using System.Linq.Expressions;
using System.Net.Security;
using System.Diagnostics;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Program;

    class Bird
    {
        private string name;
        private string color;
        private int amount;
        private int health;
        private int food;
        private int water;
        public Bird(string name_bird, string color_bird, int amount_bird) 
        {
            name = name_bird;
            color = color_bird;
            amount = amount_bird;
            health = 100;
            food = 200;
            water = 200;
        }
        public int Walk()
        {
            // we should be able to move
            var meters = Random.Shared.Next(1,50);
            if (meters >= 1 && meters <= 10)
            {
                Console.WriteLine();
                Console.WriteLine("you have not been walking for quite long (food and water goes down by 5)");
                Console.WriteLine();
                food -= 5;
                water -= 5;
                return meters;
            }
            else if (meters > 10 && meters <= 20)
            {
                Console.WriteLine();
                Console.WriteLine("you have not been walking for quite long (food and water goes down by 10)");
                Console.WriteLine();
                food -= 10;
                water -= 10;
                return meters;
            }
            else if (meters > 20 && meters <= 30)
            {
                Console.WriteLine();
                Console.WriteLine("you have not been walking for quite long (food and water goes down by 15)");
                Console.WriteLine();
                food -= 15;
                water -= 15;
                return meters;
            }
            else if (meters > 30 && meters <= 40)
            {
                Console.WriteLine();
                Console.WriteLine("you have been walking for quite long (food and water goes down by 20)");
                Console.WriteLine();
                food -= 20;
                water -= 20;
                return meters;
            }
            else if (meters > 40 && meters <= 50)
            {
                Console.WriteLine();
                Console.WriteLine("you have been walking for quite long (food and water goes down by 25)");
                Console.WriteLine();
                food -= 25;
                water -= 25;
                return meters;
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("you either refused to walk or fly or passed out or something");
                Console.WriteLine();
                return meters;
            }
        }
        public int Fly()
        {
                // we should be able to move
            var meters = Random.Shared.Next(1, 50);
            if (meters >= 1 && meters <= 10)
            {
                Console.WriteLine();
                Console.WriteLine("you have not been flying for quite long (food and water goes down by 10)");
                Console.WriteLine();
                food -= 10;
                water -= 10;
                return meters;
            }
            else if (meters > 10 && meters <= 20)
            {
                Console.WriteLine();
                Console.WriteLine("you have not been flying for quite long (food and water goes down by 20)");
                Console.WriteLine();
                food -= 20;
                water -= 20;
                return meters;
            }
            else if (meters > 20 && meters <= 30)
            {
                Console.WriteLine();
                Console.WriteLine("you have not been flying for quite long (food and water goes down by 30)");
                Console.WriteLine();
                food -= 30;
                water -= 30;
                return meters;
            }
            else if (meters > 30 && meters <= 40)
            {
                Console.WriteLine();
                Console.WriteLine("you have been flying for quite long (food and water goes down by 40)");
                Console.WriteLine();
                food -= 40;
                water -= 40;
                return meters;
            }
            else if (meters > 40 && meters <= 50)
            {
                Console.WriteLine();
                Console.WriteLine("you have been flying for quite long (food and water goes down by 50)");
                Console.WriteLine();
                food -= 50;
                water -= 50;
                return meters;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("you either refused to walk or fly or passed out or something");
                Console.WriteLine();
                return meters;
            }
        }

        public void Eat(int meter)
        {
        // we should be able to eat 
            var meters = meter;
            var eat = Random.Shared.Next(1, 50);
            if (eat >= 1 && eat <= 10 )
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (eat > 10 && eat <= 20)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (eat > 20 && eat <= 30)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (eat > 30 && eat <= 40)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (eat > 40 && eat <= 50)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some food (food goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
        }
        public void Drink(int meter)
        {
            // we should be able to drink 
            var meters = meter;
            var drink = Random.Shared.Next(1, 50);
            if (drink >= 1 && drink <= 10)
            {
                if (meters >= 1 && meters <= 15)
                { 
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (drink > 10 && drink <= 20)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (drink > 20 && drink <= 30)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 5)");
                    Console.WriteLine();
                    food += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 10)");
                    Console.WriteLine();
                    food += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 15)");
                    Console.WriteLine();
                    food += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 20)");
                    Console.WriteLine();
                    food += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 25)");
                    Console.WriteLine();
                    food += 25;
                }
            }
            else if (drink > 30 && drink <= 40)
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 5)");
                    Console.WriteLine();
                    water += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 10)");
                    Console.WriteLine();
                    water += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 15)");
                    Console.WriteLine();
                    water += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 20)");
                    Console.WriteLine();
                    water += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 25)");
                    Console.WriteLine();
                    water += 25;
                }
            }
            else if (drink > 40 && drink <= 50 )
            {
                if (meters >= 1 && meters <= 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 5)");
                    Console.WriteLine();
                    water += 5;
                }
                else if (meters > 15 && meters <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 10)");
                    Console.WriteLine();
                    water += 10;
                }
                else if (meters > 30 && meters <= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 15)");
                    Console.WriteLine();
                    water += 15;
                }
                else if (meters > 45 && meters <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 20)");
                    Console.WriteLine();
                    water += 20;
                }
                else if (meters > 60 && meters <= 75)
                {
                    Console.WriteLine();
                    Console.WriteLine("you have not been walking for quite long and found some water (water goes up by 25)");
                    Console.WriteLine();
                    water += 25;
                }
            }
        }
        public void Health_drainded()
        {
            health -= 1;
        }
        public void Water_low(int water_under) 
        {
            water -= water_under;
        }
        public void Food_low(int food_under)
        {
            food -= food_under;
        }
        public void Lucky()
        {
            Console.WriteLine();
            Console.WriteLine("your lucky you found a big place to eat and drink.");
            Console.WriteLine();
            food += 200;
            water += 200;
        }
    static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter your parrot kind otherwise 'q' to quit:");
                var user = Console.ReadLine();
                if (user.Length > 1)
                {
                    var parrots = new[] { "Parrot", "Ara", "Sun conure", "Lovebird", "Cockatoo", "Macaws", "Lorikeets", "Scarlet Macaw", "Kākāpō", "Parakeets", "Senegal parrot", "Caiques", "Amazon parrot", "Parrotlet", "Burrowing parrot", "Cockatiel", "African Grey", "Eclectus", "Pionus parrot", "Budgerigar", "African Greys", user };
                    var colors = new[] { "Blue", "Red", "Green" };
                    Bird[] birds = new Bird[parrots.Length];
                    for (int i = 0; i < parrots.Length; i++)
                    {
                        var num = Random.Shared.Next(1000, 20000);
                        var start = Random.Shared.Next(0, colors.Length);

                        birds[i] = new Bird(parrots[i], colors[start], num);
                        Console.WriteLine(birds[i]);
                        Console.WriteLine(birds[i].name);
                        Console.WriteLine(birds[i].color);
                        Console.WriteLine(birds[i].amount);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Would you like to play a little game with your parrot kind otherwise 'q' to quit:");
                    var user_second = Console.ReadLine().ToLower();
                    while (true)
                    {
                        if (user.Length > 1)
                        {
                            var move_meter = 0;
                            for (var i = 0; i < 2; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("do you want to fly or walk");
                                var move = Console.ReadLine().ToLower();

                                if (move == "fly")
                                {
                                    var user_fly = birds[birds.Length -1].Fly();
                                    move_meter += user_fly;


                                }
                                else if (move == "walk")
                                {
                                    var user_walk = birds[birds.Length -1].Walk();
                                    move_meter += user_walk;
                                }

                            }
                            birds[birds.Length - 1].Eat(move_meter);
                            Console.WriteLine(birds[birds.Length - 1].name);
                            Console.WriteLine(birds[birds.Length - 1].food);
                            Console.WriteLine(birds[birds.Length - 1].water);
                            Console.WriteLine(birds[birds.Length - 1].health);
                            Console.WriteLine();
                            birds[birds.Length - 1].Drink(move_meter);
                            Console.WriteLine(birds[birds.Length - 1].name);
                            Console.WriteLine(birds[birds.Length - 1].food);
                            Console.WriteLine(birds[birds.Length - 1].water);
                            Console.WriteLine(birds[birds.Length - 1].health);
                            Console.WriteLine();
                            if (birds[birds.Length -1].water <= 0 || birds[birds.Length -1].food <= 0)
                            {
                                Console.WriteLine();   
                                Console.WriteLine("Your hp is slowly getting drained ");
                                Console.WriteLine();
                                birds[birds.Length - 1].Health_drainded();
                                Console.WriteLine(birds[birds.Length - 1].name);
                                Console.WriteLine(birds[birds.Length - 1].food);
                                Console.WriteLine(birds[birds.Length - 1].water);
                                Console.WriteLine(birds[birds.Length - 1].health);
                                Console.WriteLine("foodwater");
                                var rd = Random.Shared.Next(0,10);
                                if (rd == 2 || rd == 4 || rd == 6 || rd == 8 || rd == 10)
                                {
                                    birds[birds.Length - 1].Lucky(); 
                                }
                            }
                            if (birds[birds.Length -1].health <= 0)
                            {
                                Console.WriteLine("Unfortunatly your bird died (RIP!)");
                                break;
                            }
                            if (birds[birds.Length - 1].water < 0)
                            {
                                birds[birds.Length - 1].Water_low(birds[birds.Length -1].water);
                                Console.WriteLine(birds[birds.Length - 1].name);
                                Console.WriteLine(birds[birds.Length - 1].food);
                                Console.WriteLine(birds[birds.Length - 1].water);
                                Console.WriteLine(birds[birds.Length - 1].health);
                                Console.WriteLine("water");
                            }
                            if (birds[birds.Length - 1].food < 0)
                            {
                                birds[birds.Length - 1].Food_low(birds[birds.Length - 1].food);
                                Console.WriteLine(birds[birds.Length - 1].name);
                                Console.WriteLine(birds[birds.Length - 1].food);
                                Console.WriteLine(birds[birds.Length - 1].water);
                                Console.WriteLine(birds[birds.Length - 1].health);
                                Console.WriteLine("food");
                            }
                        }
                        else if (user_second == "q")
                        {
                            break;
                        }
                    }
                }
                else if (user == "q")
                {
                    break;
                }
            }
        }
    }
