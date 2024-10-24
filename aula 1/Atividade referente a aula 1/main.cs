using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Escreva alguma coisa:");

    // Atividade 1
    string entrada = Console.ReadLine();
    Console.WriteLine("Você escreveu: " + entrada);

    //Atividade 2 
    Console.WriteLine("Coloque o primeiro valor:");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);

    Console.WriteLine("Coloque  o segundo valor:");
    string valor2 = Console.ReadLine();
    int numero2 = int.Parse(valor2);
    int soma = numero1 + numero2;
    Console.WriteLine("A soma dos valores é: " + soma);

    
  }
}