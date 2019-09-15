using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    class Program
    {
        public class myDictionary
        {
            public IDictionary<string, int> GetClientes()
            {
                IDictionary<string, int> clientes = new Dictionary<string, int>();
                clientes.Add("Douglas", 22);
                clientes.Add("Camila", 12);
                clientes.Add("Ricardo", 15);
                return clientes;
            }
        }
        
        static void Main(string[] args)
        {
            

            var _myDictionary = new myDictionary();
            var myClientes = _myDictionary.GetClientes();

            foreach (var cliente in myClientes)
            {
                Console.WriteLine(cliente);
                Console.ReadLine();
            }
        }
    }
}
