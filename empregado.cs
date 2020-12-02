using System;
class Empregado {
  /*
    • um primeiro nome,
    • um sobrenome, e
    • um salário mensal.
  */
  string nome, sobrenome;
  double salarioMensal;
  
  public string Nome          { get { return nome; }          set{  nome = value; } }
  public string Sobrenome     { get { return sobrenome; }     set{  sobrenome = value; } }
  public double SalarioMensal { get { return salarioMensal; } 
                                set{  
                                  if ( value < 0 ) {
                                    throw new ArgumentException("Número tem que ser positivo");
                                  } else{
                                    salarioMensal = value;
                                  }
                                } 
                              }

  public Empregado() {
    Nome          = "Anonimo";
    Sobrenome     = "";
    SalarioMensal = 0;
  }

  public Empregado( string var1, string var2, double var3 ) {
    Nome          = var1;
    Sobrenome     = var2;
    SalarioMensal = var3;
  }

  public static double dezPorcento ( double salario ) {
    
    double salarioDezPorcento = salario*0.1;
    return salarioDezPorcento;
  }



}