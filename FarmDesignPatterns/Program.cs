namespace FarmDesignPatterns
{
    public class Program
    {
        static void Main()
        {
            AnimalFarm animalFarm = new AnimalFarm();
           
                      
            animalFarm.AddAnimal(new Cow());
            animalFarm.AddAnimal(new Chicken());
            animalFarm.AddAnimal(new Cat());
            animalFarm.AddAnimal(new Dog());

            ICommand feedAnimalsCommand = new FeedAnimals(animalFarm);

            Farm farm = Farm.Instance;
            farm.Greeting();


            Console.WriteLine("\nBefore sorting:");
            animalFarm.MakeSoundsOfAnimals();

            
            animalFarm.SortAnimals();

            Console.WriteLine("\nAfter sorting:");
            animalFarm.MakeSoundsOfAnimals();


            FarmManager farmManager = new FarmManager();
            Farmer farmer1 = new Farmer("Ahmed");
            Farmer farmer2 = new Farmer("Hassan");

          
            farmer1.Subscribe(animalFarm.GetAnimal("Cow"));
            farmer1.Subscribe(animalFarm.GetAnimal("Chicken"));
            farmer2.Subscribe(animalFarm.GetAnimal("Cat"));
            farmer2.Subscribe(animalFarm.GetAnimal("Dog"));

         
            farmManager.AddFarmer(farmer1);
            farmManager.AddFarmer(farmer2);

          
            animalFarm.GetHungry();

          
            farmManager.NotifyFarmers();
            farmManager.AddCommand(feedAnimalsCommand);
            farmManager.ExecuteCommands();

        }
    }
}
