
using System;


namespace Atividade_1__Alice_Reis
{
    class Program
    {
 
static void Main(string[] args)
{
    double nota;

    Console.WriteLine("Informe a sua nota: ");
    nota = double.Parse(Console.ReadLine());


    if (nota < 4)
    {
        Console.WriteLine("Reprovado! Ficou bem distante da média");
    }
    else if (nota < 6 && nota >= 4)
    {
        Console.WriteLine("Reprovado, mas chegou perto!");

    }

    else if (nota >= 6 && nota < 9)
    {
        Console.WriteLine("Aprovado! parabéns");

    }
    else if (nota >= 9 && nota<=10)
    {
        Console.WriteLine("Aprovado! com excelência");

    }



}
        }
    }



