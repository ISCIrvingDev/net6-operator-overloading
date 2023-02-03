using OperatorOverloading.Models;
using Operators;
using System.Collections.Generic;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Sobre carga de operadores con objetos
            var beer = new Beer("Red", "Delirium", 5);
            var product = new Product();

            //product = product + beer;
            product += beer;

            Console.WriteLine("Operator Overloading");
            Console.WriteLine("Product description: " + product.Description);
            Console.WriteLine("Product price: " + product.Price);
            Console.WriteLine();

                // Sobre carga de operadores con listas
            var list1 = new ListOperators<string>() { "A", "Z" };
            var list2 = new ListOperators<string>() { "B", "Y" };

            var concatenatedList = list1 + list2;

            Console.WriteLine("List Operator Overloading");
            concatenatedList.ForEach(x => Console.WriteLine(x));
        }
    }
}