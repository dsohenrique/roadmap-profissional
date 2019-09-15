using System;

namespace LinqApp
{
    class LinqView
    {
        public void getLinqFiltrado()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando o Where e Contains retorna apenas nomes com A");
            Console.WriteLine("A lista de nomes é: Bill, Steve, James e Mohan");
            Console.WriteLine("Retorno esperado:  James");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno Linq Filtrado: {linqs.LinqFiltrado()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }
        public void getLinqOrderBy()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando OrderBy");
            Console.WriteLine("Lista de valores passado: 2, 1, 3, 5, 4");
            Console.WriteLine("Retorno esperado:  1, 2, 3, 4, 5");
            Console.ForegroundColor = ConsoleColor.Green;
            var listaId = linqs.LinqOrderBy();
            Console.WriteLine($"Retorno do OrderBy");
            foreach (var id in listaId)
            {
                Console.WriteLine($" {id.Valor} ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }

        public void getLinqSum()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando o SUM para somar todos os valores do Array");
            Console.WriteLine("A lista de valores é:  1, 2, 3, 4, 5");
            Console.WriteLine("Retorno esperado:  15");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno Linq Sum: {linqs.LinqSum()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }

        public void getLinqAverage()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando o AVERAGE para calcular a media dos valores do Array");
            Console.WriteLine("A lista de valores é:  1, 2, 3, 4, 5");
            Console.WriteLine("Retorno esperado:  3");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno Linq Average: {linqs.LinqAverage()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }
        public void getLinqMax()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando o MAX para obter o maior valor do Array");
            Console.WriteLine("A lista de valores é:  1, 2, 3, 4, 5");
            Console.WriteLine("Retorno esperado:  5");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno Linq Max: {linqs.LinqMax()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }

        public void getLinqMin()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando o MIN para obter o menor valor do Array");
            Console.WriteLine("A lista de valores é:  1, 2, 3, 4, 5");
            Console.WriteLine("Retorno esperado:  1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno Linq Min: {linqs.LinqMin()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }

        public void getLinqTake()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Limitando quantidade de registros para tres ordenando do maior para o menor");
            Console.WriteLine("Lista de valores passado: 2, 1, 3, 5, 4");
            Console.WriteLine("Retorno esperado:  5, 4, 3");
            var listaId = linqs.LinqTake();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno do Take");
            foreach (var id in listaId)
            {
                Console.WriteLine($" {id.Valor} ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }

        public void getLinqFirstOrDefault()
        {
            var linqs = new MyLinqs();

            Console.WriteLine("Usando o FirstOrDefault para obter o primeiro valor do Array que é igual a 3");
            Console.WriteLine("A lista de valores é:  1, 2, 3, 4, 5");
            Console.WriteLine("Retorno esperado:  3");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Retorno Linq FirstOrDefault: {linqs.LinqFirstOrDefault()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para continuar pressione enter!");
            Console.ReadLine();
        }
    }
}
