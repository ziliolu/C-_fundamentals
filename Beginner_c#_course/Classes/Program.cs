namespace Classes
{

    public class Order
    {
        private string _name { get; set; }

        public Order(string name)
        {
            this._name = name;
        }
     
    }

    public class Customer 
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private DateTime _birthDate { get; set; }
        private int _age
        {
            get
            {
                var timeSpan = DateTime.Today - _birthDate;
                return (timeSpan.Days/365);
            }
        }
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        readonly public List<Order> orders = new List<Order>();

           public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        public Customer ()
        {
            this._name = "";
            this._id = 0;
        }

        public Customer (string name, int id)
            : this()
        {
            this._name = name;
            this._id = id;
        }

        public Customer (string name)
            : this()
        {
            this._name = name;
        }

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, _name);
        }

        public void SetName(string newName)
        {
            _name = newName;
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            var person = new Customer("Luiza");
            person.orders.Add(new Order("Vodka"));
            person.orders.Add(new Order("Rum"));
            person["_name"] = "Ilia";
            person.Introduce("Maria");
            person.SetName("Joana");
            person.Introduce("John");
            try
            {
                System.Console.WriteLine(person["_name"]);
            }
            catch(KeyNotFoundException)
            {
                System.Console.WriteLine("Key not found");
            }
        }
    }
}