using System;

namespace Repeticao_Maior_Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

            // criar a lista
            int tamanho= 5;
            int[] lista = new int[tamanho];
            long maiorValor = lista[0];
            long menorValor = lista[0];

            for(var i =0; i < lista.Length; i++) {

                Console.Write($"Digite o {i+1}º valor: ");
                lista[i] = int.Parse(Console.ReadLine()); 
            }
                
                                
            for(var i = 0; i < lista.Length; i++){
            // se o valor atual da lista for maior que o valor que já tenho

                if(lista[i] >= maiorValor){
                
                    maiorValor = lista[i];
                    Console.WriteLine("O maior valor digitado foi: "+maiorValor);

                }
                else if(lista[i] <= menorValor)
                {
                    menorValor = lista[i];
                    Console.WriteLine("O menor valor digitado foi: "+menorValor);
                }else{
                    Console.WriteLine("");
                }
            }    
        } 
    }
}
