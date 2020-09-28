using System;

class IMC {
  public float altura, peso;
  private float imc;

  public CalculaIMC {
    Console.WriteLine("Informe seu peso: ");
    peso = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe sua altura: ");
    altura = float.Parse(Console.ReadLine());

    //Calculo
    imc = (peso / (altura*altura));

    //Condicional
    if (imc < 18.5){
      Console.WriteLine("Peso abaixo do normal");
      }
      else if ((imc > 18.5) && (imc < 25))
      {
      Console.WriteLine("Peso normal");
      }
      else  if ((imc > 25) && (imc < 30))
      {
      Console.WriteLine("Sobrepeso");
      }
      else if ((imc > 30) && (imc < 35))
      {
      Console.WriteLine("Grau de Obesidade I");
      }
      else if ((imc > 35) && (imc < 40))
      {
      Console.WriteLine("Grau de Obesidade II");
      }
      else  if (imc > 40)
      {
      Console.WriteLine("Obesidade Grau III");
      }
  }
    public float GetImc(){
    return imc;
    }
}