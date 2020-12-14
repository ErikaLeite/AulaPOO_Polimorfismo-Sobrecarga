using System;
using AulaPOO_Polimorfismo_Sobrecarga.classes;

namespace AulaPOO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            funcionario.Mostrar();
            funcionario.Mostrar(0);
            funcionario.Mostrar(9); //imprime a mensagem de não encontrado!
            funcionario.Mostrar("Berenice");

            Console.Beep();
        }
    }
}
