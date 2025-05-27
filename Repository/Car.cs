namespace Repository
{
    internal class Car
    {
        public string Model;
        public string City;
        public int Price;


        public Car(string Model, string City, int Price)
        {
            Model = Model;
            City = City;
            Price = Price;


            Console.WriteLine($"{Model},{City},{Price}");
        }
        ~Car()
        {
            Console.WriteLine("Finalizer ishe dushdu");
        }

    }
}
