using System;

namespace Story_Time
{
    class Program
    {
        private const string V = "2";

        static void Main(string[] args)
        {

            Galfia_Legends();

            first();

        }
        public static void Galfia_Legends()
        {
            Console.WriteLine("You Have Entered The Realm Of Galfia");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }
        public static void first()
        {
            string userName, Class, Weapon, Magic;
            Console.Write("What is your username: ");
            userName = Console.ReadLine();
           
            if(string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Value cant be empty! input your name");
                userName = Console.ReadLine();
                first();
              }

            Console.Write("What is your class: ");
            Class = Console.ReadLine();


            if (string.IsNullOrEmpty(Class))
            {
                Console.WriteLine("Value cant be empty! input your class");
                Class = Console.ReadLine();
            }

            Console.Write("Choose your weapon: ");
            Weapon = Console.ReadLine();


            if (string.IsNullOrEmpty(Weapon))
            {
                Console.WriteLine("Value cant be empty! input your weapon");
                 Weapon = Console.ReadLine();
            }

            Console.Write("What is your preferred Magic type: ");
            Magic = Console.ReadLine();

            if (string.IsNullOrEmpty(Magic))
            {
                Console.WriteLine("Value cant be empty! input your magic Type");
                Magic = Console.ReadLine();
                first();
            }

            Console.WriteLine("Hello, " + userName);


            Console.WriteLine("I see you prefer to fight as a " + Class + " that is a formidable choice.");
            Console.WriteLine("Selecting a " + Weapon + " as your arm of choice will strike fear into the hearts of your enemies. Excellent decision.");
            Console.WriteLine("Matching " + Magic + " with your " + Weapon + " and with you being a " + Class + " will make your journey manageable.");
            Console.WriteLine(" ----------------");


            Console.WriteLine("Be mindful, be keen, be aware because........ Now your journey Begins............");
            Console.ReadLine();
            Console.Clear();

            string choice;

            Console.WriteLine("You leave the castle and venture into th dark Homitter forrest...");
            Console.WriteLine("Dark and snarling branches make your journey arduous, but you persevere...");
            Console.WriteLine("You here a sound behind you, and grab your " + Weapon + " to prepare yourself for battle");
            Console.WriteLine("Red Eyes come closer as you turn around and face what you may think is the worst fear of all. ");
            Console.WriteLine("What do you do? ");
            Console.WriteLine("1.Strike with " + Weapon + " to strike at the grimacing figure");
            Console.WriteLine("2.Conjure your " + Magic + " to cast a spell and attempt to vanquish your foe");
            Console.WriteLine("3.Run for your life deeper into the forrest, and hope you arent pursued");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "Strike with":
                case "use your weapon":
                    {
                        Console.WriteLine("You lung forward with your " + Weapon + " And Pierce the howling beast in its side");
                        Console.WriteLine("You swing again with the deadly " + Weapon + " but this time you miss");
                        Console.WriteLine("As you ready in a battle stance with the " + Weapon + " once more, you notice the beast shrinking away in fear");
                        Console.WriteLine("Press 'enter' to continue");
                        Console.ReadLine();
                        second();
                        break;
                        
                    }
                case "2":
                case "Conjure":
                case "conjure your":
                    {
                        Console.WriteLine("You call to the heavens and chant to bring forth your " + Magic + " And the creature doesnt stop charging");
                        Console.WriteLine("You notice the incoming fiend and try to hurry and complete the spell ");
                        Console.WriteLine("You should have drawn your " + Weapon + " the spell isnt conjured in time, and now you are at the mercy of a foul beast");
                        Console.WriteLine("You weren't quick enough, you will be carrion for all the beassts to feast on");
                        Console.ReadLine();
                        GameOVER();
                        break;
                    }
                case "3":
                case "Run":
                case "run for your life":
                    {
                        Console.WriteLine("you run off into the forest abandoning you " + Weapon + " because it is too heavy");
                        Console.WriteLine("you have failed your kingdom, but not many have lived to tell the tale of the forrest, maybe you are one of the luck ones");
                        Console.WriteLine("if you find your way head home, you may be honored you may be disgraced");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }

            }


        }
        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = { "Now that you have  vanquished your foe, do you pray to the gods for taking a life no matter what harm it may have done you!!",
                "You decide to pick up the beast and use it as a prize to take back to the kingdom to let the people know of your bravery",
            " The Beast was actually one of many, and they strike at once"};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Once again you are accosted do you fight; Fight or Run?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "fight" || secChoice == "f")
            {
                Console.WriteLine("You wage battle with two more of these wolf like beings");
                Console.WriteLine("You fight valiantly, hacking and slashing and firing away, the true heart of a warrior");
                Console.WriteLine(" the true heart of a warrior, you have successfully sent you foes to hell, beaten and battered you continue on your journey.");
                Console.ReadLine();
                third();
            }
            else if (secChoice == "run" || secChoice == "r")
            {
                second();
            } else
            {
                Console.WriteLine("Neither choosing and option to fight and or run results in your demise");
                Console.WriteLine("Press 'Enter' to try again");
                Console.ReadLine();
                GameOVER();

            }
        } public static void third()
        {
            int paths;

            Console.WriteLine("You come to a clearing and there are three (select 1 to 3)  paths for you to follow, you select the first");
            Console.Write("Path: ");
            int.TryParse(Console.ReadLine(), out paths);

            while (paths < 2)
            {
                Console.WriteLine("You have chosen the correct path, you are on your way home and you have the medals to prove your bravery");
                YouWon();
                Console.WriteLine("the path you have chosen is a long arduous one, you have been lead astray and run into a battalion of orcs, I bid you adiue, brave warrior");
                GameOVER();

                Console.WriteLine("This path you have chosen has lead you back into the forrest. You are never to be heard from again. Tall tales say you have become a soldier of the forrest, who knows really");
                
                
                Console.Write("Path: ");
                int.TryParse(Console.ReadLine(),out paths);
            }
            Console.WriteLine("I Hope you made the right decision");
        }
        public static void GameOVER()
        {
            Console.WriteLine("you have desecrated the kingdowm you serve");
        }
        public static void YouWon()
        {
            Console.WriteLine("Your name shall go down in honor and be in the legends of great warriors");
        }




    }
    }



