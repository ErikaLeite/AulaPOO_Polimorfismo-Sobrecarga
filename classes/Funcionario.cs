using System;

namespace AulaPOO_Polimorfismo_Sobrecarga.classes
{
    public class Funcionario
    {
        public string[] lista = {"Miranda", "Atila", "Berenice", "Carmen"};

        public void Mostrar()               //exibe todo o conteúdo do array
        {
            foreach (var item in lista)
            {   
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item); //TUDO o que está armazenado no array
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice)    //exibe apenas o que está no indice
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (indice < lista.Length)
            {
                Console.WriteLine(lista[indice]); //Mostra APENAS o que está armazenado na posição do array
            }else{
                System.Console.WriteLine("Funcionário não encontrado.");
            }
            Console.ResetColor();
        }

        public void Mostrar(string busca) //exibe somente dados da busca existente no array
        {
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (item == busca)
                {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
                
            }
        }
    }
} 