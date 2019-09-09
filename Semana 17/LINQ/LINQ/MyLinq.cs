using System.Linq;
namespace LINQ
{
    public class MyLinq
    {
        // Usando o Where e Contains
        public string LinqFiltrado()
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            var myLinqQuery = names.Where(x => x.Contains('a'));

            foreach (var name in myLinqQuery)
            {
                return name;
            }
            //Retorna Bill, James, Mohan, Steve

            return "Algo deu errado!";
        }

        //Usando OrderBy
        int[] id = { 2, 1, 3, 5, 4 };
        public string LinqOrderBy() => id.OrderBy(x => x % 2 == 0).ToString(); //Retorna 2, 4, 1, 3, 5

        //Funções de agregação(Sum, Average, Min, Max)
        int[] values = { 1, 2, 3, 4, 5 };
        public int LinqSum() => values.Sum(values => values); //Retorna 15

        public double LinqAverage() => values.Average(values => values); //Retorna 5

        public double LinqMax() => values.Max(values => values); //Retorna 1

        public double LinqMin() => values.Min(values => values); //Retorna 5

        //Limitando quantidade de registros
        public string LinqTake() => values.OrderByDescending(values => values).Take(3).ToString(); //Retorna 5, 4, 3
        public int LinqFirstOrDefault() => values.OrderBy(values => values).FirstOrDefault(values => values == 1);//Retorna 1
    }
}
