using System;
using System.Collections.Generic;

namespace DictionaryProject
{
    class Program
    {
        public class myDictionary
        {
            public IDictionary<string, string> GetClientes()
            {
                //Criando um Dictionary de chave string e valor string
                IDictionary<string, string> clientes = new Dictionary<string, string>();
                clientes.Add("Douglas", "22");
                clientes.Add("Camila", "12");
                clientes.Add("Ricardo", "15");

                return clientes;
            }
        }
        
        static void Main(string[] args)
        {
            var _myDictionary = new myDictionary();
            var myClientes = _myDictionary.GetClientes();

            Console.WriteLine("Percorrendo todos os itens do Dictionary");
            foreach (var cliente in myClientes)
            {
                Console.WriteLine("Chave: " + cliente.Key);
                Console.WriteLine("Valor: " + cliente.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Percorrendo todos os itens do Dictionary por chaves");
            foreach (var cliente in myClientes)
            {
                Console.WriteLine("Chave: " + cliente.Key);
                Console.WriteLine();
            }

            Console.WriteLine("Percorrendo todos os itens do Dictionary por valor");
            foreach (var cliente in myClientes)
            {
                Console.WriteLine("Valor: " + cliente.Value);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
