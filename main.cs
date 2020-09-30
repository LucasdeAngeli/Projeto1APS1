using System;

class MainClass {
  public static void Main (string[] args) {
    string nome_usuario, nome_remedio;
    float imc;

    Console.WriteLine("Informe seu nome: ");
    nome_usuario = Console.ReadLine();

    //Estrutura do menu
    Console.WriteLine ("Bem vindo ao Remed.Io, {0}", nome_usuario);
    Console.WriteLine ("=====================");
    Console.WriteLine ("Selecione a opção no menu abaixo:");
    Console.WriteLine ("_________________________________");
    Console.WriteLine ("1-Inserir remédio");
    Console.WriteLine ("2-Calcular IMC");
    Console.WriteLine ("3-Gerar Relatório");
    Console.WriteLine ("0-Sair");

    while (opção != 0){
      if (opção = 1){
        remedio = new remedio();
        Console.WriteLine ("Infrome o nome do remédio: ");
        nome_remedio = Console.ReadLine();
        nome_remedio.remedio = Console.ReadLine();
        Console.WriteLine ("Nome do remédio: ", nome_remedio);
      }
      else if (opção = 2){
        imc = new imc();
        Console.WriteLine ("Informe seu peso: ");
        peso = new peso();
        peso.imc = Console.ReadLine();
        Console.WriteLine ("Informe sua altura: ");
        altura = new altura();
        altura.imc = Console.ReadLine();
        imc = (peso / (altura*altura));
        Console.WriteLine("Seu IMC é de {0}", imc);
      }
      else if (opção = 3){
        //problemas ao criar relatorio-erro de importação
      }
      else{
        Console.WriteLine("Você escolheu Sair, volte logo <3");
      }
    }
  }
}