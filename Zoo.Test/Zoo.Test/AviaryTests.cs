using System.Xml.Linq;
using Zoo;
 namespace Zoo.Test
   
{
    public class AviaryTests
    {
        [TestCase]
        public void PlusAnimalTest()
        {
            Aviary bigAviary = new Aviary("��� ������", "�������", 500);
            List<AbstractAnimals> elephant = new List<AbstractAnimals>()
         {
            new ElephantAnimals("����", "�������", 70, "����", "����������", "���", "����", 300, 4, "������� �������"),
            new ElephantAnimals("����", "�������", 70, "����", "����������", "���", "����", 300, 5, "������� �������")
         };
            ElephantAnimals elephantFaina = new ElephantAnimals("����", "�������", 70, "����", "����������", "����", "�����", 300, 4, "������� �������");

            List<AbstractAnimals> actual = bigAviary.PlusAnimal(elephant, elephantFaina);
            Assert.AreEqual(elephant.ToString(), actual.ToString());
        }

        [TestCase]
        public void MinusAnimalTest()
        {
            Aviary bigAviary = new Aviary("��� ������", "�������", 500);
            List<AbstractAnimals> elephant = new List<AbstractAnimals>()
         {
            new ElephantAnimals("����", "�������", 70, "����", "����������", "���", "����", 300, 4, "������� �������"),
            new ElephantAnimals("����", "�������", 70, "����", "����������", "���", "����", 300, 5, "������� �������"),
            new ElephantAnimals("����", "�������", 70, "����", "����������", "����", "�����", 300, 4, "������� �������")
         };

            List<AbstractAnimals> actual = bigAviary.MinusAnimal(elephant, elephant[1]);
            Assert.AreEqual(elephant.ToString(), actual.ToString());
        }
    }
}