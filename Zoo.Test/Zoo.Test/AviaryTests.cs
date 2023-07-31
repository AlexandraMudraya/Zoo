using System.Xml.Linq;
using Zoo;
 namespace Zoo.Test
   
{
    public class AviaryTests
    {


        //Aviary bigAviary = new Aviary("��� ������", "�������", 500);

        //List<AbstractAnimals> elephant = new List<AbstractAnimals>()
        // {
        //    new ElephantAnimals("����", "�������", 70, "����", "����������", "���", "����", 300, 4, "������� �������"),
        //    new ElephantAnimals("����", "�������", 70, "����", "����������", "���", "����", 300, 5, "������� �������")
        // };

        //ElephantAnimals elephantFaina = new ElephantAnimals("����", "�������", 70, "����", "����������", "����", "�����", 300, 4, "������� �������");

        //List<AbstractAnimals> newElephant;

        [TestCase(elephant, elephantFaina, newElephant)]
        public void PlusAnimalTest(List<AbstractAnimals> animals, AbstractAnimals animal, List<AbstractAnimals> expected)
        {
            List<AbstractAnimals> actual = Aviary.PlusAnimal(animals, animal);
            Assert.AreEqual(expected, actual);
        }
    }
}