using System;
using System.Collections.Generic;
using System.Linq;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //create animal containers.
            Aviary Aviary = new Aviary();
            Burrows Burrows = new Burrows();
            CreepyCrawlyBox CreepyCrawlyBox = new CreepyCrawlyBox();
            Tank Tank = new Tank();
            Terrarium Terrarium = new Terrarium();
            //collection of individual fishbowls:
            FishbowlCollection FishbowlCollection = new FishbowlCollection();

            Aviary.Occupants.Add(new Finch());
            Aviary.Occupants.Add(new Parakeet());
            Aviary.Occupants.Add(new Finch());
            Aviary.Occupants.Add(new Parakeet());
            Aviary.Occupants.Add(new Finch());
            Aviary.Occupants.Add(new Parakeet());

            //Bettas are territorial, so only one per fishbowl in the collection.
            for (int fishbowls = 1; fishbowls <= 8; fishbowls += 1)
            {
                SmallFishBowl fishbowl = FishbowlCollection.AddSmallFishbowl();
                if (fishbowls <= 5)
                {
                    fishbowl.SingleOccupant = new BettaFish();
                }
                else
                {
                    fishbowl.SingleOccupant = new DwarfPufferFish();
                }
            }

            //lots of ants
            for (int ants = 1; ants <= 306000; ants += 1)
            {
                CreepyCrawlyBox.Occupants.Add(new Ant());
            }

            //and one queen
            CreepyCrawlyBox.Occupants.Add(new AntQueen());

            for (int worms = 1; worms <= 20; worms += 1)
            {
                CreepyCrawlyBox.Occupants.Add(new Earthworm());
            }

            //Tank for Amphibious reptiles.
            Tank.Occupants.Add(new CopperheadSnake());
            Tank.Occupants.Add(new Terrapin());
            Tank.Occupants.Add(new Terrapin());

            Burrows.Occupants.Add(new Gerbil());
            Burrows.Occupants.Add(new Gerbil());
            Burrows.Occupants.Add(new Mouse());
            Burrows.Occupants.Add(new Mouse());

            Terrarium.Occupants.Add(new TimberRattlesnake());

            //list all animals in container, then list each type and how many of each.
            Console.WriteLine($"The Aviary has {Aviary.Occupants.Count} animals:");
            IEnumerable<IAnimal> UniqueFlyers = Aviary.Occupants.Distinct(new AnimalComparer());
            foreach (IAnimal Animal in UniqueFlyers)
            {
                Console.WriteLine($"{Aviary.Occupants.Where(occupant => occupant.Name() == Animal.Name()).ToList().Count} {Animal.Name()}(s).");
            }
            Console.WriteLine("=====================");

            Console.WriteLine($"The Burrows has {Burrows.Occupants.Count} animals:");
            IEnumerable<IAnimal> UniqueBurrowers = Burrows.Occupants.Distinct(new AnimalComparer());
            foreach (IAnimal Animal in UniqueBurrowers)
            {
                Console.WriteLine($"{Burrows.Occupants.Where(occupant => occupant.Name() == Animal.Name()).ToList().Count} {Animal.Name()}(s).");
            }
            Console.WriteLine("=====================");

            Console.WriteLine($"The Creepy Crawly Box has {CreepyCrawlyBox.Occupants.Count} animals:");
            IEnumerable<IAnimal> UniqueCrawlies = CreepyCrawlyBox.Occupants.Distinct(new AnimalComparer());
            foreach (IAnimal Animal in UniqueCrawlies)
            {
                Console.WriteLine($"{CreepyCrawlyBox.Occupants.Where(occupant => occupant.Name() == Animal.Name()).ToList().Count} {Animal.Name()}(s).");
            }
            Console.WriteLine("=====================");

            Console.WriteLine($"The Tank has {Tank.Occupants.Count} animals:");
            IEnumerable<IAnimal> UniqueAmphibious = Tank.Occupants.Distinct(new AnimalComparer());
            foreach (IAnimal Animal in UniqueAmphibious)
            {
                Console.WriteLine($"{Tank.Occupants.Where(occupant => occupant.Name() == Animal.Name()).ToList().Count} {Animal.Name()}(s).");
            }
            Console.WriteLine("=====================");

            Console.WriteLine($"The Terrarium has {Terrarium.Occupants.Count} animals:");
            IEnumerable<IAnimal> UniqueTerrestrials = Terrarium.Occupants.Distinct(new AnimalComparer());
            foreach (IAnimal Animal in UniqueTerrestrials)
            {
                Console.WriteLine($"{Terrarium.Occupants.Where(occupant => occupant.Name() == Animal.Name()).ToList().Count} {Animal.Name()}(s).");
            }
            Console.WriteLine("=====================");

            //number of containers, occupants of each container
            IEnumerable<ISolitary> SolitaryFish = FishbowlCollection.AllContainers.Select(container => container.SingleOccupant);
            Console.WriteLine($"There are {FishbowlCollection.AllContainers.Count} individual fishbowls, each containing one of:");
            IEnumerable<IAnimal> UniqueSolitaryFish = SolitaryFish.Distinct(new AnimalComparer());
            foreach (IAnimal Animal in UniqueSolitaryFish)
            {
                Console.WriteLine($"{SolitaryFish.Where(occupant => occupant.Name() == Animal.Name()).ToList().Count} {Animal.Name()}(s).");
            }


        }
    }
}
