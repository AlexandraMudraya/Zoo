using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Aviary
    {
        public string Name { get; set; }

        public string Biome { get; set; }

        public double SquareM2 { get; set; }

        public Aviary(string name, string biome, double squareM2)
        {
            Name = name;
            Biome = biome;
            SquareM2 = squareM2;
        }

        public void ListAnimals(List<AbstractAnimals> animals)
        {
            string temp = $"В вольере {Name} живут: ";

            foreach (AbstractAnimals item in animal)
            {
                temp += $"{item.Species} {item.Name}, ";
            }
            Console.WriteLine(temp);
            //Console.Write("В вольере живут: ");
            //for (int i = 0; i < animals.Count; i++)
            //{
            //    Console.Write($"{animals[i].Species} {animals[i].Name} ");
            //}
            //Console.WriteLine();
        }
    
        public List<AbstractAnimals> PlusAnimal(List<AbstractAnimals> animals, AbstractAnimals animal)
        {
            double freeSquare = SquareM2;
            for (int i = 0;i < animals.Count;i++)
            {
                freeSquare -= animals[i].SquareM2;
            }
            if (Biome == animal.Biome && animal.PredatorOrHerbivore == animals[0].PredatorOrHerbivore && freeSquare >= animal.SquareM2) 
            {
                animals.Add(animal);
                Console.WriteLine($"{animal.Species} {animal.Name} добавлен в этот вольер");
                Console.Write("Теперь в вольере живут: ");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.Write($"{animals[i].Species} {animals[i].Name} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{animal.Species} {animal.Name} не может жить в этом вольере");
            }
            Console.WriteLine();
            return animals;
        }

        public List<AbstractAnimals> MinusAnimal(List<AbstractAnimals> animals, AbstractAnimals animal)
        {
            animals.Remove(animal);

                Console.WriteLine($"{animal.Species} {animal.Name} отселен из этого вольера");
                Console.Write("Теперь в вольере живут: ");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.Write($"{animals[i].Species} {animals[i].Name} ");
                }
            Console.WriteLine();
            Console.WriteLine();
            return animals;
        }

        public List<AbstractAnimals> FeedAnimals (List<AbstractAnimals> animals, double foodWeight, string food)
        {
            double freeFoodWeight = 0;
            if (food == animals[0].Food)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    freeFoodWeight = foodWeight - animals[i].NeedFoodVolume;
                    if (freeFoodWeight >= 0)
                    {
                        Console.WriteLine($"{animals[i].Species} {animals[i].Name} наелся(ась)");
                    }
                    else
                    {
                        double addFoodWeight = freeFoodWeight + animals[i].NeedFoodVolume;
                        Console.WriteLine($"{animals[i].Species} {animals[i].Name} не наелся(ась), нужно еще {addFoodWeight} кг: {animals[0].Food}");
                    }
                    foodWeight = freeFoodWeight;
                }
                if (freeFoodWeight > 0)
                {
                    Console.WriteLine($"Остаток еды в кормушках: {freeFoodWeight} кг {food}");
                }
                else
                {
                    Console.WriteLine("Еды в кормушках не осталось");
                }
                
            }
            if (food != animals[0].Food)
            {
                Console.WriteLine("Тип еды не подходит для обитателей данного вольера");
            }
            Console.WriteLine();
            return animals;
        }

        public void MakeASoundAllAnimals (List<AbstractAnimals> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{animals[i].Species} {animals[i].Name} говорит {animals[i].Sound}");
            }
            Console.WriteLine();
        }
    }
}
