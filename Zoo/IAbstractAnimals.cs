namespace Zoo
{
    public interface IAbstractAnimals
    {
        int Age { get; set; }
        string Biome { get; set; }
        string Food { get; set; }
        string Name { get; set; }
        double NeedFoodVolume { get; set; }
        string PredatorOrHerbivore { get; set; }
        string Sound { get; set; }
        string SpecialAction { get; set; }
        string Species { get; set; }
        double SquareM2 { get; set; }

        void CanDo(string action);
        void Eat(string Food, double FoodVolume);
        void MakeASound();
        void Play(string spesiesPlayer, string namePlayer);
    }
}