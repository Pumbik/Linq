using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        public class AutoColl
        {
            public string MarkaAvto { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public override string ToString()
            {
                return "Avto: "+ MarkaAvto +" "+ Model+" "+ Year +" "+ Color+ " color";
            }
        }

        public class Client
        {
            public string MarkaAvto { get; set; }
            public string Name { get; set; }
            public int Phone { get; set; }

            public override string ToString()
            {
                return "Client Name: " + Name + " avto: "+ MarkaAvto+ " phone: "+ Phone;
            }
        }
        
        static void Main(string[] args)
        {
            var autocoll = new List<AutoColl>
            {
                new AutoColl {MarkaAvto="BMW", Model="525", Year=2015, Color="Black"},
                new AutoColl {MarkaAvto="Audi", Model="Q7", Year=2016, Color="White"},
                new AutoColl {MarkaAvto="Honda", Model="SRV", Year=2008, Color="Black"},
                new AutoColl {MarkaAvto="Tesla", Model="T7", Year=2017, Color="DarkBlue"},
                new AutoColl {MarkaAvto="Hyindai", Model="Tukson", Year=2010, Color="Red"}
            };
            foreach (var auto in autocoll)
            {
                Console.WriteLine(auto.ToString());
            }

            Console.WriteLine(new string('-', 30));

            var client = new List<Client>
            {
                new Client {MarkaAvto="BMW", Name="Kolya", Phone=5255669 },
                new Client {MarkaAvto="Audi", Name="Vasya", Phone=76544 },
                new Client {MarkaAvto="Honda", Name="Masha", Phone=5254679 },
                new Client {MarkaAvto="Tesla", Name="Alex", Phone=5888889 },
                new Client {MarkaAvto="Hyindai", Name="Kol", Phone=6677669 },
            };
            foreach (var clients in client)
            {
                Console.WriteLine(clients.ToString());
            }

            Console.WriteLine(new string('-', 30));

            var query = from avto in autocoll
                        join cl in client on avto.MarkaAvto equals cl.MarkaAvto
                        select new
                        {
                            Name = cl.Name,
                            Phone= cl.Phone,
                            MarkaAvto= avto.MarkaAvto,
                            Model= avto.Model,
                            Year=avto.Year,
                            Color=avto.Color
                        };
        

            foreach (var item in query)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Name, item.Phone, item.MarkaAvto, item.Model, item.Year, item.Color);
            } 


        }
    }
}
