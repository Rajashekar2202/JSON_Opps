namespace DataInventoryManagment
{
    class program
    {
        public static void Main(String[] args)
        {
            string Path = "C:\\Users\\Guest 1\\Desktop\\New folder\\DataInventoryManagment\\DataInventoryManagment\\FetchJsonForRice.cs ";
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            Rice data = fetchJsonForRice.Read(Path);

            Console.WriteLine(data.typesOfRice.name);
            Console.WriteLine(data.typesOfRice.price);
            Console.WriteLine(data.typesOfRice.weight);

            Console.WriteLine("-----------------------------------");

           
            Console.WriteLine(data.typesOfWheat.name);
            Console.WriteLine(data.typesOfWheat.price);
            Console.WriteLine(data.typesOfWheat.weight);

            Console.WriteLine("-----------------------------------");

            
            Console.WriteLine(data.typesOfPulse.name);
            Console.WriteLine(data.typesOfPulse.price);
            Console.WriteLine(data.typesOfPulse.weight);

            Console.WriteLine("-----------------------------------");



        }
    }
}