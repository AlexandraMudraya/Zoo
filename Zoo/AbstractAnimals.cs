using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class AbstractAnimals : IAbstractAnimals
    {
        public string Species { get; set; }

        public string Biome { get; set; }

        public double SquareM2 { get; set; }

        public string Food { get; set; }

        public string PredatorOrHerbivore { get; set; }

        public string Sound { get; set; }

        public string Name { get; set; }

        public double NeedFoodVolume { get; set; }

        public int Age { get; set; }

        public string SpecialAction { get; set; }

        public void MakeASound()
        {
            Console.WriteLine($"{Name} говорит {Sound}");
        }

        public abstract void Eat(string Food, double FoodVolume);

        public void CanDo(string action)
        {
            if (SpecialAction == action)
            {
                Console.WriteLine($"{Name} умеет {SpecialAction}");
            }
            else
            {
                Console.WriteLine($"{Name} не умеет {action}");
            }
        }

        public abstract void Play(string spesiesPlayer, string namePlayer);
    }
}
