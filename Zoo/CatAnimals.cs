using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    public class CatAnimals : AbstractAnimals, IMeower
    {
        public CatAnimals(string species, string biome, double squareM2, string food, string predatorOrHerbivore, string sound, string name, double needFoodVolume, int age, string doSpecialAction)
        {
            Species = species;
            Biome = biome;
            SquareM2 = squareM2;
            Food = food;
            PredatorOrHerbivore = predatorOrHerbivore;
            Sound = sound;
            Name = name;
            NeedFoodVolume = needFoodVolume;
            Age = age;
            SpecialAction = doSpecialAction;
        }

        public override void Eat(string Food, double FoodVolume)
        {
            if (Food != "рыба" && Food != "корм для кошек")
            {
                throw new ArgumentException($"{Name} не будет это есть");
            }

            Console.WriteLine($"{Name} кушает {Food}: {FoodVolume} кг");

            if (FoodVolume >= NeedFoodVolume)
            {
                Console.WriteLine($"{Name} наелся(ась)");
            }
            else
            {
                Console.WriteLine($"{Name} не наелся(ась)");
            }
        }

        public override void Play(string spesiesPlayer, string namePlayer)
        {
            if (spesiesPlayer == Species)
            {
                Console.WriteLine($"{Name} и {namePlayer} играют");
            }
            else
            {
                Console.WriteLine($"{Name}  и  {namePlayer} не будут играть вместе");
            }
        }

        public void Meowing()
        {
            Console.WriteLine($"{Name} мяукает");
        }
    }
}
