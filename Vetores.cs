using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Vetores
{

    public class Program 
    {
        public static void Main()
        {
			Console.WriteLine("---Exercicio 1---");
			//inserir 10 nomes em 1 vetor e mostra-los na tela.
			
			//declaração de vetor com 10 conteudos.
			string[] nomes = new string [10];
			int i;
			//a variavel "i" serve para contar o numero de pessoas de 1 em 1.
			for (i=0;i<10;i++)
			{
				//dentro das chaves ({}) irá o valor de "i" que fica do lado de fora após a virgula ","
				Console.WriteLine("Digite o {0}° nome: ", i+1);
				//vai inserindo cada nome no vetor sendo indicado a posição tambem por "i"
				nomes[i]=Console.ReadLine();
			}
			for (i=0;i<10;i++)
			{
				//mostra todos os nomes informados, 1 por 1 de acordo com "i". no final o "conteudo" so nome de cada indice do vetor.
				Console.WriteLine("{0}° nome: {1} ", i+1, nomes[i]);
			}
			
        }
    }
}