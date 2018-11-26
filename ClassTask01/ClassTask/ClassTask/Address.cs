
namespace ClassTask
    {
        class Address
        {
            private string city;

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            private string country;

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            private string street;

            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            private int huoseNum;

            public int HuoseNum
            {
                get { return huoseNum; }
                set { huoseNum = value; }
            }

            public Address(string city, string country, string street, int huoseNum)
            {
                City = city;
                Country = country;
                Street = street;
                HuoseNum = huoseNum;

            }
            public string get_info()
            {
                string date = $"city: {City}\n Country: {Country}\n Street: {Street}\n huose number: {HuoseNum}";
                   return date;
            }

        }
    }


