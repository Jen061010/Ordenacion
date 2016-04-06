using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new List<Cliente>(){
                new Cliente(){Id=7, Name="Pedro",   Phone=9},
                new Cliente(){Id=6, Name="Pedro",    Phone=10},
                new Cliente(){Id=2, Name="Alberto", Phone=8},
            };
            var query = from c in cliente
                        orderby c.Name , c.Id ascending,c.Phone descending
                        select c;
            foreach (var bucle in query) {
                Console.WriteLine(bucle.Name+" "+bucle.Id+ " "+ bucle.Phone);
            }
            Console.ReadLine();
        }
    }
}
