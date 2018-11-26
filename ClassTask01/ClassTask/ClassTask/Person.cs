
namespace ClassTask
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Address newAddress;

        public Address NewAddress
        {
            get { return newAddress; }
            set { newAddress = value; }
        }
        public Person()
        { }
        public Person(string name, Address newAddress)
        {
            Name = name;
            NewAddress = newAddress;

        }

        public string getInfo()
        {
            string date = $"{Name}{NewAddress.get_info()}";

            return date;
        }

    }
}
