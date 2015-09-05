using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum.Array();
            Console.ReadKey();
        }

        static void Cars()
        {
            IEnumerable<Car> cars1;

            //inherits after IEnumerable
            ICollection<Car> cars2;            

            //inherits after IEnumerable, ICollection
            IList<Car> cars3;            

            //inherits after IEnumerable
            IReadOnlyList<Car> cars4; 
                 
        }
    }
}
