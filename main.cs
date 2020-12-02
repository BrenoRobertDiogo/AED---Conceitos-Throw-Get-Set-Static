using System;

class MainClass {
  public static void Main () {
    Empregado breno = new Empregado("Breno", "Robert", 480);
    double aumento1 = Empregado.dezPorcento( breno.SalarioMensal );
    Console.WriteLine($"Seu salário foi de {aumento1}");

    Empregado armando = new Empregado("Matheus", "Tsui", 15000);
    double aumento2 = Empregado.dezPorcento( armando.SalarioMensal );
    Console.WriteLine($"Salário de {armando.Nome} foi aumentado em 10% ({Empregado.dezPorcento( aumento2 )}R$) ");

  }
}