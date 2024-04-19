/*
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.
*/

using System;
using System.Runtime.InteropServices;

namespace Exercicio16
    {
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person();

            Console.Write("Nome 1: ");
            person.Name = Console.ReadLine();
            Console.Write("Idade 1: ");
            person.Age = int.Parse(Console.ReadLine());
            
            Console.Write("Nome 2: ");
            person2.Name = Console.ReadLine();
            Console.Write("Idade 2: ");
            person2.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {person.Name}\nIdade: {person.Age}");
            Console.WriteLine($"Nome: {person2.Name}\nIdade: {person2.Age}");



        }
    }
}