using System;

//namespace Zoo.Test
//{
//    public class AnimalsTests
//    {
//        [TestCase("сено", 300, "индийский слон", "Петя", "Петя наелся(ась)")]
//        [TestCase("сено", 30, "индийский слон", "Петя", "Петя не наелся(ась)")]
//        [TestCase("мясо", 4, "бенгальский тигр", "Матильда", "Матильда не наелся(ась)")]
//        [TestCase("рыба", 6, "бенгальский тигр", "Матильда", "Матильда наелся(ась)")]
//        [TestCase("рыба", 0.5, "императорский пингвин", "Симба", "Симба наелся(ась)")]
//        public void EatTest(string Food, double FoodVolume, string Species, string Name, string expected)
//        {
//            string actual = Animals.Eat(Food, FoodVolume, Species, Name);
//            Assert.AreEqual(expected, actual);
//        }

//        [TestCase("рыба", 300, "индийский слон", "Петя")]
//        [TestCase("мясо", 300, "индийский слон", "Петя")]
//        [TestCase("сено", 10, "императорский пингвин", "Симба")]
//        [TestCase("мясо", 0.3, "императорский пингвин", "Симба")]
//        [TestCase("сено", 10, "бенгальский тигр", "Матильда")]
//        public void EatTest_WhenFoodIsWrong_ShuldArgumentExaption(string Food, double FoodVolume, string Species, string Name)
//        {
//            Assert.Throws<ArgumentException>(() => Animals.Eat(Food, FoodVolume, Species, Name));
//        }
//    }
//}