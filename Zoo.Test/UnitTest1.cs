using System;

//namespace Zoo.Test
//{
//    public class AnimalsTests
//    {
//        [TestCase("����", 300, "��������� ����", "����", "���� ������(���)")]
//        [TestCase("����", 30, "��������� ����", "����", "���� �� ������(���)")]
//        [TestCase("����", 4, "����������� ����", "��������", "�������� �� ������(���)")]
//        [TestCase("����", 6, "����������� ����", "��������", "�������� ������(���)")]
//        [TestCase("����", 0.5, "������������� �������", "�����", "����� ������(���)")]
//        public void EatTest(string Food, double FoodVolume, string Species, string Name, string expected)
//        {
//            string actual = Animals.Eat(Food, FoodVolume, Species, Name);
//            Assert.AreEqual(expected, actual);
//        }

//        [TestCase("����", 300, "��������� ����", "����")]
//        [TestCase("����", 300, "��������� ����", "����")]
//        [TestCase("����", 10, "������������� �������", "�����")]
//        [TestCase("����", 0.3, "������������� �������", "�����")]
//        [TestCase("����", 10, "����������� ����", "��������")]
//        public void EatTest_WhenFoodIsWrong_ShuldArgumentExaption(string Food, double FoodVolume, string Species, string Name)
//        {
//            Assert.Throws<ArgumentException>(() => Animals.Eat(Food, FoodVolume, Species, Name));
//        }
//    }
//}