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

        public void ListAnimals(AbstractAnimals[] array)
        {
            Console.WriteLine($"В вольере {Name} живут: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i].Species} {array[i].Name} ");
            }
            Console.WriteLine( );
            Console.WriteLine();
        }
    
        public AbstractAnimals[] PlusAnimal(AbstractAnimals[] array, AbstractAnimals animal)
        {
            double freeSquare = SquareM2;
            for (int i = 0;i < array.Length;i++)
            {
                freeSquare = freeSquare - array[i].SquareM2;
            }
            if (Biome == animal.Biome && animal.PredatorOrHerbivore == array[0].PredatorOrHerbivore && freeSquare >= animal.SquareM2) 
            {
                Array.Resize(ref array, array.Length+1);
                array[array.Length-1] = animal;
                Console.WriteLine($"{animal.Species} {animal.Name} добавлен в этот вольер");
                Console.Write("Теперь в вольере живут: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i].Species} {array[i].Name} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{animal.Species} {animal.Name} не может жить в этом вольере");
            }
            Console.WriteLine();
            return array;
        }

        public AbstractAnimals[] MinusAnimal(AbstractAnimals[] array, AbstractAnimals animal)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (animal == array[i])
                {
                    var temp = array[i];
                    array[i] = array[array.Length-1];
                    array[array.Length-1] = temp;
                }
            }
                Array.Resize(ref array, array.Length - 1);

                Console.WriteLine($"{animal.Species} {animal.Name} отселен из этого вольера");
                Console.Write("Теперь в вольере живут: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i].Species} {array[i].Name} ");
                }
            Console.WriteLine();
            Console.WriteLine();
            return array;
        }

        public AbstractAnimals[] FeedAnimals (AbstractAnimals[] array, double foodWeight, string food)
        {
            double freeFoodWeight = 0;
            if (food == array[0].Food)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    freeFoodWeight = foodWeight - array[i].NeedFoodVolume;
                    if (freeFoodWeight >= 0)
                    {
                        Console.WriteLine($"{array[i].Species} {array[i].Name} наелся(ась)");
                    }
                    else
                    {
                        double addFoodWeight = freeFoodWeight + array[i].NeedFoodVolume;
                        Console.WriteLine($"{array[i].Species} {array[i].Name} не наелся(ась), нужно еще {addFoodWeight} кг: {array[0].Food}");
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
            if (food != array[0].Food)
            {
                Console.WriteLine("Тип еды не подходит для обитателей данного вольера");
            }
            Console.WriteLine();
            return array;
        }

        public void MakeASoundAllAnimals (AbstractAnimals[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i].Species} {array[i].Name} говорит {array[i].Sound}");
            }
            Console.WriteLine();
        }
    }
}
