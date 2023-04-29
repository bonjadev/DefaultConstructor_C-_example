namespace PrimerConstructors1
{
    class Car
    {
        public string model;

        public Car()
        {
            model = "Mustang"; //ovde kontruktor sluzi za inicijalizaciju pocetnih vrednosti
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }

    }
}