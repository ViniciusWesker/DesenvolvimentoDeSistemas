using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LacosRepeticao
{

    public class Program 
    {
        public static void Main()
        {
			Console.WriteLine("XxXExercicio1XxX");
			
			int x;
			//A variavel "x" serve para indicar o numero que sera multiplicado por 4 nos comandos seguinte, a cada tick do loop seu valor aumenta em 1.
			for (x=1;x<=10;x++)
			{
				Console.WriteLine(x+"x4="+(4*x));
			}
			
			Console.WriteLine("XxXExercicio2XxX");
			
			int n;
			int m;
			//a variavel "n" é o numero (de 1 a 10) que ira multiplicar o numero escolhido pelo usuario na variavel "m"
			Console.WriteLine("Digite o numero que voce quer ver a tabuada:");
			m=int.Parse(Console.ReadLine());
			for (n=1;n<=10;n++)
			{
				Console.WriteLine(n+"x"+m+"="+(m*n));
			}
			
			Console.WriteLine("XxXExercicio3XxX");
			
			double N;
			double soma=0;
			double resultado;
			int X;
			//a variavel "X" é a quantidade de numeros que usaremos até o fim do loop, na variavel "N" serão armazenados os numeros que o usuario digitar, na variavel "soma" que seu valor inicial = 0 iremos somar em cada tick o valor da variavel "N" digitada pelo usuario (atenção para o comando soma=soma+N), o resultado disso entra ma variavel "resultado" no final e é dividido po 15 pata tirar a média dos 15 numeros inseridos.
			for (X=1;X<=15;X++)
			{
			 Console.WriteLine("Digite 15 numeros para saber a media entre eles:");
			 N=double.Parse(Console.ReadLine());
			 soma=soma+N;
			}
			 resultado=soma/15;
			 Console.WriteLine("a media dos 15 numeros é:"+resultado);
			
			 
			Console.WriteLine("XxXExercicio4XxX");
			
			 
			 int maior=0;
			 int numero=1;
			 //a variavel "maior" é onde ficará armazenado o maior numero digitado, por isso no começo deve começar em 0(zero). a variavel "numero começa em 1 para que quando chegue no comando "while" e ser diferente de zero (!=0) comecar o loop. O comando "if" deve ficar dentro de "while" para que o comando dele sempre fique wm loop enquanto o usuario não digitar 0 (zero). muita atenção na hora de comparar as variaveis e se todas as pontuações estão corretas para evitar erros, qualquer pontuação errada pode resultar em falhas.
			 while (numero!=0)
			 {
			 Console.WriteLine("Digite alguns numeros e lhe diremos qual foi o maior. (quando terminar de digitar os numeros pressione 0(zero))");
			 numero=int.Parse(Console.ReadLine());
			 
			 if (numero>maior || maior==0)
			 {
			 	maior=numero;
			 }
			 }
			Console.WriteLine("O maior numero digitado foi: "+maior);
			
			
			Console.WriteLine("XxXExercicio5XxX");
			
			int number;
			int par=0;
			int impar=0;
			int positivo=0;
			int negativo=0;
			//no lugar do comando "do" poderia ser "while" mas ai a variavel number teria que ser =1. todas as outras variaveis começam igual a 0(zero) pois seus valores serão creditados com "++" toda vez que for digitado um numero que se encaixe em sua condição. Se o resto da divisão por 2 (%2) for 0(zero) então ele é par. o comando "do" será executado enquanto a condição de "while" estiver ativa.
			do
			{
			Console.WriteLine("digite alguns valores a seguir (para parar aperte 0(zero)):");
			number=int.Parse(Console.ReadLine());
			if (number%2==0)
			{
				par++;
			}
			else
			{
				impar++;
			}
			if (number>0)
			{
				positivo++;
			}
			else
			{
				negativo++;
			}
			}
			while (number!=0);
			Console.WriteLine("Dos numeros que digitou, "+par+" são pares, "+impar+" são impares, "+positivo+" são positivos e "+negativo+" são negativos.");
			
        }
    }
}