using System;

namespace Text_Based_Inset_Name
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Ints section
            int correct = 0;
            int Arraycount = 0;

            //string section
            string Intro;
            string PlayerName;
            string Gender;
            string[] Inventory = new string[20];
            string Input;

            do
            {
                //Introduction Part 
                Console.Clear();
                Console.WriteLine("Welcome, To RPG SIMULATOR 2017");
                Console.WriteLine("Please Press ENTER To Continue");
                Intro = Console.ReadLine().ToUpper();

                //Name Section
                Console.Write("Please Enter Your Name: ");
                PlayerName = Console.ReadLine();

                Console.WriteLine("Hello " + PlayerName + " Your Name has been added to the system, Press ENTER To Continue");
                Console.ReadLine();

                //Gender Section
                Console.Clear();

                bool hasChosenGender = false;
                do
                {
                    Console.WriteLine("Are you a BOY or a GIRL?");
                    Console.WriteLine("Boy");
                    Console.WriteLine("Girl");
                    Gender = Console.ReadLine().ToUpper();

                    if (Gender == "BOY" || Gender == "Boy" || Gender == "boy")
                    {
                        correct = 1;
                        hasChosenGender = true;
                    }
                    else if (Gender == "GIRL" || Gender == "Girl" || Gender == "girl")
                    {
                        correct = 1;
                        hasChosenGender = true;
                    }
                    else
                    {
                        hasChosenGender = false;
                    }

                } while (!hasChosenGender);

            } while (correct == 0);


            Console.WriteLine("Thank you " + PlayerName);
            Console.ReadLine();
            //Initialization finished.

            //------------------------
            // SECTION 1

            //Quest and Choices Section

            Console.Clear();
            Console.WriteLine("You awake in some sort of cell, all you can see is the walls around you, a door with a padlock on it and a bucket in the corner of the room");
            Console.WriteLine("What do you want to do?:");

            Console.WriteLine("Look around the area for more objects? (LOOK)");
            Console.WriteLine("Look in the Bucket, see what it contains? (BUCKET)");
            Console.WriteLine("Go up to the door? (DOOR)");
            Console.WriteLine("Look at the walls around you? (WALLS)");

            Console.Write("type HELP to see these options again.");

            int firstSectionComplete = 0;
            do
            {
                Console.WriteLine("You are in the cell.");
                Input = Console.ReadLine().ToUpper();

                //Help
                if (Input == "HELP")
                {
                    Console.WriteLine("Look around the area? (LOOK)");
                    Console.WriteLine("Look in the Bucket, to see what it contains? (BUCKET)");
                    Console.WriteLine("Go up to the Cell door? (DOOR)");
                    Console.WriteLine("Look at the walls around you? (WALLS)");
                }

                //Look
                if (Input == "LOOK")
                {
                    int leave = 0;
                    do
                    {
                        Console.WriteLine("You look around the Dirty cell to find it is still very dirty");
                        Console.Write("Leave? Y/N");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "Y") { leave = 1; }
                        if (Input == "N") { leave = 0; }
                    } while (leave == 0);
                }

                //Bucket
                if (Input == "BUCKET")
                {
                    int leave = 0;
                    do
                    {
                        Console.WriteLine("Inside the bucket a large rock sits at the bottom, you pick it up and add it to your inventory");
                        Inventory[0] = "Rock";
                        Console.WriteLine("Go back? Y/N");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "Y") { leave = 1; }
                        if (Input == "N") { leave = 0; }
                    } while (leave == 0);
                }

                //Door
                if (Input == "DOOR")
                {
                    int leave = 0;
                    do
                    {
                        Console.WriteLine("The door is heavy but the padlock is weak, maybe you could smash it with something?");
                        Console.Write("Use an Item? Y/N");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "Y") { leave = 1; }
                        if (Input == "N") { leave = 0; }
                    } while (leave == 0);

                    if (Inventory[0] != null)
                    {
                        int smash = 0;
                        do
                        {
                            Console.WriteLine("The Rock you picked up looks heavy enough to smash the padlock off");
                            Console.WriteLine("Give it a Go? Y/N");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "N") { smash = 0; }
                            if (Input == "Y")
                            {
                                smash = 1;

                                int carryOnwards = 0;
                                do
                                {
                                    Console.WriteLine("It worked! With one swing of the rock in hand the old padlock shatters and the door is now open");
                                    Console.WriteLine("Carry Onwards? Y/N");
                                    Input = Console.ReadLine().ToUpper();
                                    if (Input == "Y") { carryOnwards = 1; firstSectionComplete = 1; }
                                    if (Input == "N") { carryOnwards = 0; }
                                } while (carryOnwards == 0);
                            }

                        } while (smash == 0);
                    }
                }

                //Walls
                if (Input == "WALLS")
                {
                    int leave = 0;
                    do
                    {
                        Console.WriteLine("The walls are cold to the touch, and also still very dirty");
                        Console.WriteLine("Go Back? Y/N");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "Y") { leave = 1; }
                        if (Input == "N") { leave = 0; }
                    } while (leave == 0);
                }


                // Inventory section testing
                if (Input == "INVENTORY" || Input == "INV")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Your Inventory Contains:");
                        for (Arraycount = 0; Arraycount < 20; Arraycount++)
                        {
                            int inventory_possition = Arraycount + 1;
                            Console.SetCursorPosition(0, inventory_possition);
                            Console.WriteLine("{0}", Inventory[Arraycount]);
                        }
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        {
                            correct = 1;
                        }
                        if (Input != "BACK")
                        {
                            correct = 0;
                        }
                    } while (correct == 0);

                    if (Input == "BACK")
                    {
                        correct = 1;
                    }
                    if (Input != "BACK")
                    {
                        correct = 0;
                    }

                }

            } while (firstSectionComplete == 0);

            Console.Clear();
            Console.Write("Well done! You have completed the first section of the Game!.");

            //------------------------
            // SECTION 2

            int secondSectionComplete = 0;
            do
            {



            } while (secondSectionComplete == 0);
        }
    }
}
