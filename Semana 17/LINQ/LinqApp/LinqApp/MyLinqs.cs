using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class MyLinqs
    {
        // Usando o Where e Contains
        public string LinqFiltrado()
        {
            string[] names = { "Bill", "Steve", "James", "Morty" };

            var myLinqQuery = names.Where(x => x.Contains('a'));

            foreach (var name in myLinqQuery)
            {
                return name;
            }
            //Retorna James

            return "Algo deu errado!";
        }

        //Usando OrderBy
        Id[] id = { new Id { Valor = 2 },
                    new Id { Valor = 1 },
                    new Id { Valor = 3 },
                    new Id { Valor = 5 },
                    new Id { Valor = 4 }};
        public IEnumerable<Id> LinqOrderBy() => id.OrderBy(id => id.Valor); //Retorna 1, 2, 3, 4, 5

        //Funções de agregação(Sum, Average, Min, Max)
        int[] values = { 1, 2, 3, 4, 5 };
        public int LinqSum() => values.Sum(values => values); //Retorna 15

        public double LinqAverage() => values.Average(values => values); //Retorna 3

        public double LinqMax() => values.Max(values => values); //Retorna 5

        public double LinqMin() => values.Min(values => values); //Retorna 1

        //Limitando quantidade de registros
        public IEnumerable<Id> LinqTake() => id.OrderByDescending(id => id.Valor).Take(3); //Retorna 5, 4, 3
        public int LinqFirstOrDefault() => values.OrderBy(values => values).FirstOrDefault(values => values == 3);//Retorna 3
    }
}
