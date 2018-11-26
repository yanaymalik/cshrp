

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p2.Name = "naor";
            p2.NewAddress = new Address("ariel","isreal","bolbol",13);
            System.Console.WriteLine(p2.getInfo());
            
        }
    }
}
