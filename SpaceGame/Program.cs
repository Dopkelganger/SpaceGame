﻿using System;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////Place me after the player initializes character///////////////////////////////
            Difficulty difficulty = Difficulty.Easy; //this will be intialized by the player

            Planet p1 = new Planet("Gallifrey", "Gold", difficulty, 15, 100, 100);
            Planet p2 = new Planet("Cadia", "Gold", difficulty, 15, 100, 100);
            Planet p3 = new Planet("Caprica", "Fuel", difficulty, 100, 15, 100);
            Planet p4 = new Planet("Dagobah", "Fuel", difficulty, 100, 15, 100);
            Planet p5 = new Planet("Cybertron", "Hull Material", difficulty, 100, 200, 15);
            ///////////////////////////////Place me after the player initializes character///////////////////////////////

            Menu menu = new Menu();
            menu.ShowMainMenu();
            int option = menu.GetUserInput(menu.MainMenuOptions);
            //if user picks new game
                Ship ship = new Ship();
                //assign starting planet
                    //give intro paragraph and explain situation
                    //ship.ToString()
                    //show planet menu
            //if user picks load game
                //check the username and load appropriate save file
            //if user picks quit
                //enviornment.exit()


        }


            

        static void DisplayMessageOnEnter(string message)
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(message);
        }

        static void RandomEventsDemo(Difficulty difficulty)
        {
            // Difficulty:

            // Hard - event runs 30% of the time
            // Medium - event runs 20% of the time
            // Easy - event runs 10% of the time

            // Events - set to hard difficulty for the demo
            HullEvent hullEvent = new HullEvent(difficulty);
            FuelEvent fuelEvent = new FuelEvent(difficulty);
            GoldEvent goldEvent = new GoldEvent(difficulty);
            TimeEvent timeEvent = new TimeEvent(difficulty);

            Console.WriteLine("Starting sim [CTRL-C to exit]");
            while (true)
            {
                // DEMO ONLY

                // Random events - These can be triggered at any point we want throughout the program, and return a string describing
                // the event. Pass in the players ship so the event has something to affect.
                // When creating events, just pass in a Difficulty enum

                // --- Simulation for testing random events ---

                // create an example ship
                Ship vulcan = new Ship();

                // show its initial stats
                DisplayMessageOnEnter($"Created new ship\n{vulcan}");

                // shops at store...
                DisplayMessageOnEnter("You go shopping at the local market...");

                // we went to the store, so lets trigger a GoldEvent
                DisplayMessageOnEnter(goldEvent.Trigger(vulcan));

                DisplayMessageOnEnter(vulcan.ToString());

                // travels to planet...
                DisplayMessageOnEnter("You start your journey to <planet> ...");

                // we are traveling, so lets trigger a hull event and a fuel event, even a time event
                DisplayMessageOnEnter(timeEvent.Trigger(vulcan));
                DisplayMessageOnEnter(hullEvent.Trigger(vulcan));
                DisplayMessageOnEnter(fuelEvent.Trigger(vulcan));

                DisplayMessageOnEnter(vulcan.ToString());

                DisplayMessageOnEnter("Press enter to run simulation again");
            }

        }
    }
}
