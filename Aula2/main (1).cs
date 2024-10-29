using System;

class Program {
  public static void Main (string[] args) {
  //Solicitando a nota que o aluno tirou

    Console.WriteLine("Insira sua nota:(0 a 100)");
    int nota = int.Parse(Console.ReadLine());
    //Verificando se a nota é valida 
    if(nota >= 0 && nota <= 100){
      
    }
      //Verificando se a nota é azul
      if(nota >= 60){
        Console.WriteLine("Parabéns! Você foi aprovado!");
      }else{
        Console.WriteLine("Estude mais você esta de repureração");
      }
      else{
        Console.WriteLine("Nota invalida, insira outra nota");
      }
  }
}
