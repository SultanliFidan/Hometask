namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf { HP = 100, AttackDamage = 20 };
            Elephant elephant = new Elephant { HP = 150 };

           
            wolf.Hunt(elephant);
            Console.WriteLine($"Ovdan sonra Elephantın HP-si: {elephant.HP}");

            ZooCage<Wolf, Meat> wolfCage = new ZooCage<Wolf, Meat>();
            wolfCage.Animal = wolf;
            wolfCage.Food = new Meat { Calorie = 200, Type = MeatType.Beef };

            Console.WriteLine($"Qefesdeki canavarın HP-si: {wolfCage.Animal.HP}");
            Console.WriteLine($"Qefesdeki yemeyin kalorisi: {wolfCage.Food.Calorie}");
        }
    }
}
