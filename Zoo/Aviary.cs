using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //AbstractAnimals[] array = Aviary.PlusAnimal(Aviary aviary, AbstractAnimals[] array, AbstractAnimals animal);


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
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i].Species} {array[i].Name} ");
            }
            Console.WriteLine();
        }
    

        public AbstractAnimals[] PlusAnimal(Aviary aviary, AbstractAnimals[] array, AbstractAnimals animal)
        {
            double freeSquare = aviary.SquareM2;
            for (int i = 0;i < array.Length;i++)
            {
                freeSquare = freeSquare - array[i].SquareM2;
            }
            if (aviary.Biome == animal.Biome && animal.PredatorOrHerbivore == array[0].PredatorOrHerbivore && freeSquare >= animal.SquareM2) 
            {
                Array.Resize(ref array, array.Length+1);
                array[array.Length-1] = animal;
                Console.WriteLine($"{animal.Species} {animal.Name} добавлен в этот вольер");
                Console.Write("В вольере живут: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i].Species} {array[i].Name} ");
                }
            }
            else
            {
                Console.WriteLine($"{animal.Species} {animal.Name} не может жить в этом вольере");
            }
            
            return array;
        }

        public void MinusAnimal(Aviary aviary, AbstractAnimals[] array, AbstractAnimals animal)
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
                Console.Write("В вольере живут: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i].Species} {array[i].Name} ");
                }
            
        }
    }
}
