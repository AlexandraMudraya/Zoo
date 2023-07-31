using System.Xml.Linq;
using Zoo;
 namespace Zoo.Test
   
{
    public class AviaryTests
    {
        [TestCase]
        public void PlusAnimalTest()
        {
            Aviary bigAviary = new Aviary("для слонов", "тропики", 500);
            List<AbstractAnimals> elephant = new List<AbstractAnimals>()
         {
            new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4, "трубить хоботом"),
            new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом")
         };
            ElephantAnimals elephantFaina = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "аууф", "Фаина", 300, 4, "трубить хоботом");

            List<AbstractAnimals> actual = bigAviary.PlusAnimal(elephant, elephantFaina);
            Assert.AreEqual(elephant.ToString(), actual.ToString());
        }

        [TestCase]
        public void MinusAnimalTest()
        {
            Aviary bigAviary = new Aviary("для слонов", "тропики", 500);
            List<AbstractAnimals> elephant = new List<AbstractAnimals>()
         {
            new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4, "трубить хоботом"),
            new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом"),
            new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "аууф", "Фаина", 300, 4, "трубить хоботом")
         };

            List<AbstractAnimals> actual = bigAviary.MinusAnimal(elephant, elephant[1]);
            Assert.AreEqual(elephant.ToString(), actual.ToString());
        }
    }
}