using System.Xml.Linq;
using Zoo;
 namespace Zoo.Test
   
{
    public class AviaryTests
    {


        //Aviary bigAviary = new Aviary("для слонов", "тропики", 500);

        //List<AbstractAnimals> elephant = new List<AbstractAnimals>()
        // {
        //    new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4, "трубить хоботом"),
        //    new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом")
        // };

        //ElephantAnimals elephantFaina = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "аууф", "Фаина", 300, 4, "трубить хоботом");

        //List<AbstractAnimals> newElephant;

        [TestCase(elephant, elephantFaina, newElephant)]
        public void PlusAnimalTest(List<AbstractAnimals> animals, AbstractAnimals animal, List<AbstractAnimals> expected)
        {
            List<AbstractAnimals> actual = Aviary.PlusAnimal(animals, animal);
            Assert.AreEqual(expected, actual);
        }
    }
}