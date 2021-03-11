using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
			//if = se, else = senão.
			Console.WriteLine("Exercicio 1");
			
			int valor1;
			int valor2;
			
			Console.WriteLine("Digite um valor:");
			valor1=int.Parse(Console.ReadLine());
			Console.WriteLine("Digite outro valor:");
			valor2=int.Parse(Console.ReadLine());
			
			if (valor1>valor2)
			{
				Console.WriteLine("o maior valor é:"+valor1);
			}
			else
			{
				Console.WriteLine("o maior valor é:"+valor2);
			}
			
			Console.WriteLine("Exercicio 2");
			
			string nome;
			int anoN;
			int anoA;
			
			Console.WriteLine("Digite seu nome:");
			nome=Console.ReadLine();
			Console.WriteLine("Digite o ano em que voce nasceu:");
			anoN=int.Parse(Console.ReadLine());
			Console.WriteLine("Digite seu ano atual:");
			anoA=int.Parse(Console.ReadLine());
			
			if (anoA-anoN>=18)
			{
				Console.WriteLine(nome+ " voce é maior de idade");
			}
			else
			{
				Console.WriteLine(nome+ " voce é menor de idade");
			}
			
			Console.WriteLine("exercicio 3");
			
			int n1;
			int n2;
			int n3;
			
			Console.WriteLine("digite um numero:");
			n1=int.Parse(Console.ReadLine());
			Console.WriteLine("digite outro numero:");
			n2=int.Parse(Console.ReadLine());
			Console.WriteLine("digite mais um numero:");
			n3=int.Parse(Console.ReadLine());
			
			if (n1<n2&&n2<n3)
			{
				Console.WriteLine("ordem crescente: "+n1+"-"+n2+"-"+n3);
			}
			
			if (n1<n3&&n2>n3)
			{
				Console.WriteLine("ordem crescente: "+n1+"-"+n3+"-"+n2);
			}
			
			if (n1<n2&&n1>n3)
			{
				Console.WriteLine("ordem crescente: "+n3+"-"+n1+"-"+n2);
			}
			
			if (n1>n2&&n2>n3)
			{
				Console.WriteLine("ordem crescente: "+n3+"-"+n2+"-"+n1);
			}
			
			if (n2<n1&&n1<n3)
			{
				Console.WriteLine("ordem crescente: "+n2+"-"+n1+"-"+n3);
			}
			
			if (n2<n3&&n3<n1)
			{
				Console.WriteLine("ordem crescente: "+n2+"-"+n3+"-"+n1);
			}
			
			Console.WriteLine("Exercicio 4");
			
			int delta;
			int a;
			int b;
			int c;
			int x;
			double x1;
			double x2;
			
			Console.WriteLine("digite o valor de a:");
			a=int.Parse(Console.ReadLine());
			Console.WriteLine("digite o valor de b:");
			b=int.Parse(Console.ReadLine());
			Console.WriteLine("digite o valor de c:");
			c=int.Parse(Console.ReadLine());
			delta=b*b-4*a*c;
			x=-b/2*a;
			x1=(-b+Math.Sqrt(+delta))/2*a;
			x2=(-b-Math.Sqrt(+delta))/2*a;
			
			
			if (+delta<0)
			{
				Console.WriteLine("Não há raízes.");
			}
			if (+delta==0)
			{
				Console.WriteLine("a raíz é:"+x);
			}
			if (+delta>0)
			{
				
			}
			
			
        }
    }
}