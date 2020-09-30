using System;

class Remedio {

  public CadastraRemedio {

  string nome_remedio;
  string tipo_remedio;
  
  DateTime data = new DateTime();
  Console.WriteLine(data);

  int ano;
  int mes;
  int dia;

  Console.WriteLine("Informe o dia: ");
  dia = int.Parse(Console.ReadLine());
  Console.WriteLine("Informe o mês: ");
  mes = int.Parse(Console.ReadLine());
  Console.WriteLine("Informe o ano: ");
  ano = int.Parse(Console.ReadLine());

  DateTime dataEntrada = new DateTime(ano, mes, dia);

  Console.WriteLine(dataEntrada);
  }
}