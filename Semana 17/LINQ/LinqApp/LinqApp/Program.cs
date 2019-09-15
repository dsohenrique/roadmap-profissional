using System;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var linq = new LinqView();

            linq.getLinqFiltrado();
            linq.getLinqOrderBy();
            linq.getLinqSum();
            linq.getLinqAverage();
            linq.getLinqMax();
            linq.getLinqMin();
            linq.getLinqTake();
            linq.getLinqFirstOrDefault();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fim da execução do projeto :)");
            Console.ReadLine();

        }
    }
}
