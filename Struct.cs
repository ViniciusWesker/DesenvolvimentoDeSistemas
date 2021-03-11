using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        
        public struct data
            {
             	public int dia;
             	public int mes;
             	public int ano;
            }
           
        public struct relacao
        {
           	public string aluno;
           	public double nota1;
           	public double nota2;
           	public double media;
           	public string situacao;
        }  
        
        public static void Main() 
        {
           
           //Exercício 1: Escreva um programa que peça para o usuário digitar uma data contendo dia, mês e ano e o programa deverá informar se é uma data válida ou não. Obs.: criar obrigatoriamente uma struct para a data.
           
           data d1;
           bool bissexto;
           
           Console.WriteLine("Digite um dia do mês (1~31):");
           d1.dia = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite um mês (1~12)");
           d1.mes = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite um ano:");
           d1.ano = int.Parse(Console.ReadLine());
           
           //esse negocio de ano bissexto deu trabalho...
           //Adicionei uma variavel bool para definir se elw é ou não.
           if (d1.ano % 4 == 0 && d1.ano % 100 != 0 || d1.ano % 400 == 0)
           {
           bissexto=true;
           }
           else 
           {
           bissexto=false;
           }
           
           //fiz tudo em um if só pq não consegui juntar varios.
           if 
            (
            d1.mes == 1 && d1.dia >= 1 && d1.dia <= 31 
            || d1.mes == 3 && d1.dia >= 1 && d1.dia <= 31
            || d1.mes == 5 && d1.dia >= 1 && d1.dia <= 31 
            || d1.mes == 7 && d1.dia >= 1 && d1.dia <= 31 
            || d1.mes == 8 && d1.dia >= 1 && d1.dia <= 31 
            || d1.mes == 10 && d1.dia >= 1 && d1.dia <= 31 
            || d1.mes == 12 && d1.dia >= 1 && d1.dia <= 31
            
            || d1.mes == 4 && d1.dia >= 1 && d1.dia <= 30
            || d1.mes == 6 && d1.dia >= 1 && d1.dia <= 30
            || d1.mes == 9 && d1.dia >= 1 && d1.dia <= 30
            || d1.mes == 11 && d1.dia >= 1 && d1.dia <= 30
            
            //TENTANDO INTRODUZIR ANO BISSEXTO
            //tava errando pq tava escrevendo a variavel errada
            || d1.mes == 2
            && bissexto == true
            && d1.dia >= 1
            && d1.dia <= 29
            || d1.mes == 2
            && bissexto == false
            && d1.dia >= 1
            && d1.dia <= 28
            )
            
            {
            	Console.ForegroundColor=
            	ConsoleColor.Blue;
            	Console.WriteLine("Valida");
            	Console.ResetColor();
            }
           
            else
            {
            	Console.ForegroundColor=
            	ConsoleColor.Red;
            	Console.WriteLine("Invalida");
            	Console.ResetColor();
            }
           
           
         /*
         Exercício 2: Escreva um programa que leia o nome de 15 alunos, onde cada aluno devem ser registradas 2 notas e um campo para armazenar a média. No campos média deverá ser calculada a média das duas notas do aluno. Ao final deverá ser exibido na tela um relatório com os dados de todos os alunos (nome, notas, media) e também a informação se o aluno foi aprovado ou reprovado (média para aprovação >= 7,0). Para o caso de aprovado exibir todos os dados do aluno na cor azul, caso contrário exibir os dados na cor vermelha.  
         Obs.: Usar obrigatoriamente struct, vetor e laço de repetição.
         */
          
         // PARA VER O METODO SEM VETOR HABILITAR O COMANDO A BAIXO
         //relacao a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15;
         
         //TENTANDO INTRODUZIR O VETOR
         
         //codigo do professor:
         /*
         Aluno[] alunos = new Aluno[15];
         for (x=0;x<15;x++) 
         Console.Write("Nome:"); 
         alunos[x].nome=Console.ReadLine();
         */
         
         //tentando encaixar no codigo geral:
         
         //vetor para os nomes
         relacao[] nomes = new relacao [16];
         int x;
         
         for (x=1;x<16;x++)
         {
         Console.WriteLine("insira o nome do "+x+"° aluno",x+1);
         nomes[x].aluno = Console.ReadLine();
         }
         
         //vetor para a 1 nota
         relacao[] notas1 = new relacao [16];
         
         for (x=1;x<16;x++)
         {
         Console.WriteLine("insira a 1° nota  de " +nomes[x].aluno+ ":",x+1);
         notas1[x].nota1 = double.Parse(Console.ReadLine());
         }
         
         //vetor para a 2 nota
         relacao[] notas2 = new relacao [16];
         
         for (x=1;x<16;x++)
         {
         Console.WriteLine("insira a 2° nota  de " +nomes[x].aluno+ ":",x+1);
         notas2[x].nota2 = double.Parse(Console.ReadLine());
         }
         
         //vetor para a media
         relacao[] medias = new relacao [16];
         
         for (x=1;x<16;x++)
         {
         	medias[x].media = (notas1[x].nota1 + notas2[x].nota2) /2;
         }
         
         //vetor da situação
         relacao[] situacoes = new relacao [16];
         
         for (x=1;x<16;x++)
         {
         if (medias[x].media >= 7)
         {
         	situacoes[x].situacao = "Aprovado";
         }
         else
         {
         	situacoes[x].situacao = "Reprovado";
         }
         }
         
         //vetor da relacao final
         
         Console.WriteLine("RELAÇÃO DOS ALUNOS:");
         
         relacao[] final = new relacao [16];
         
         for (x=1;x<16;x++)
         {
         	if (situacoes[x].situacao == "Aprovado")
         	{
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine
         	(
         		nomes[x].aluno + "|" 
         		+ notas1[x].nota1 + "|" 
         		+ notas2[x].nota2 + "|" 
         		+ medias[x].media + "|" 
         		+ situacoes[x].situacao
         	);
         	
         	}
         	else
         	{
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine
         	(
         		nomes[x].aluno + "|" 
         		+ notas1[x].nota1 + "|" 
         		+ notas2[x].nota2 + "|" 
         		+ medias[x].media + "|" 
         		+ situacoes[x].situacao
         	);
         	
         	}
         }
         
         //ABAIXO FICA O PROGRAMA SEM VETOR, PARA HABILITALO LIBERAR A LINHA 104 E OS COMANDOS ABAIXO E DESABILITAR OS VETORES ACIMA
         /*
         Console.WriteLine("Digite o nome do 1° aluno:");
         a1.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 1° aluno:");
         a1.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 1° aluno:");
         a1.nota2=double.Parse(Console.ReadLine());
         
         a1.media=(a1.nota1+a1.nota2)/2;
         if (a1.media>=7)
         {
         	a1.situacao="Aprovado";
         }
         else
         {
         	a1.situacao="Reprovado";
         }
         	
         Console.WriteLine("Digite o nome do 2° aluno:");
         a2.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 2° aluno:");
         a2.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 2° aluno:");
         a2.nota2=double.Parse(Console.ReadLine());
         
         a2.media=(a2.nota1+a2.nota2)/2;
         if (a2.media>=7)
         {
         	a2.situacao="Aprovado";
         }
         else
         {
         	a2.situacao="Reprovado";
         }	
         	
         Console.WriteLine("Digite o nome do 3° aluno:");
         a3.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 3° aluno:");
         a3.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 3° aluno:");
         a3.nota2=double.Parse(Console.ReadLine());
         
         a3.media=(a3.nota1+a3.nota2)/2;
         if (a3.media>=7)
         {
         	a3.situacao="Aprovado";
         }
         else
         {
         	a3.situacao="Reprovado";
         }	
         	
         Console.WriteLine("Digite o nome do 4° aluno:");
         a4.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 4° aluno:");
         a4.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 4° aluno:");
         a4.nota2=double.Parse(Console.ReadLine());
         
         a4.media=(a4.nota1+a4.nota2)/2;
         if (a4.media>=7)
         {
         	a4.situacao="Aprovado";
         }
         else
         {
         	a4.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 5° aluno:");
         a5.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 5° aluno:");
         a5.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 5° aluno:");
         a5.nota2=double.Parse(Console.ReadLine());
         
         a5.media=(a5.nota1+a5.nota2)/2;
         if (a5.media>=7)
         {
         	a5.situacao="Aprovado";
         }
         else
         {
         	a5.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 6° aluno:");
         a6.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 6° aluno:");
         a6.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 6° aluno:");
         a6.nota2=double.Parse(Console.ReadLine());
         
         a6.media=(a6.nota1+a6.nota2)/2;
         if (a6.media>=7)
         {
         	a6.situacao="Aprovado";
         }
         else
          {
         	a6.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 7° aluno:");
         a7.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 7° aluno:");
         a7.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 7° aluno:");
         a7.nota2=double.Parse(Console.ReadLine());
         
         a7.media=(a7.nota1+a7.nota2)/2;
         if (a7.media>=7)
         {
         	a7.situacao="Aprovado";
         }
         else
         {
         	a7.situacao="Reprovado";
         }
          	
         Console.WriteLine("Digite o nome do 8° aluno:");
         a8.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 8° aluno:");
         a8.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 8° aluno:");
         a8.nota2=double.Parse(Console.ReadLine());
         
         a8.media=(a8.nota1+a8.nota2)/2;
         if (a8.media>=7)
         {
         	a8.situacao="Aprovado";
         }
         else
         {
         	a8.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 9° aluno:");
         a9.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 9° aluno:");
         a9.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 9° aluno:");
         a9.nota2=double.Parse(Console.ReadLine());
         
         a9.media=(a9.nota1+a9.nota2)/2;
         if (a9.media>=7)
         {
         	a9.situacao="Aprovado";
         }
         else
         {
         	a9.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 10° aluno:");
         a10.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 10° aluno:");
         a10.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 10° aluno:");
         a10.nota2=double.Parse(Console.ReadLine());
         
         a10.media=(a10.nota1+a10.nota2)/2;
         if (a10.media>=7)
         {
         	a10.situacao="Aprovado";
         }
         else
         {
         	a10.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 11° aluno:");
         a11.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 11° aluno:");
         a11.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 11° aluno:");
         a11.nota2=double.Parse(Console.ReadLine());
         
         a11.media=(a11.nota1+a11.nota2)/2;
         if (a11.media>=7)
         {
         	a11.situacao="Aprovado";
         }
         else
         {
         	a11.situacao="Reprovado";
         }	
         	
         Console.WriteLine("Digite o nome do 12° aluno:");
         a12.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 12° aluno:");
         a12.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 12° aluno:");
         a12.nota2=double.Parse(Console.ReadLine());
         
         a12.media=(a12.nota1+a12.nota2)/2;
         if (a12.media>=7)
         {
         	a12.situacao="Aprovado";
         }
         else
         {
         	a12.situacao="Reprovado";
         }	
         	
         Console.WriteLine("Digite o nome do 13° aluno:");
         a13.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 13° aluno:");
         a13.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 13° aluno:");
         a13.nota2=double.Parse(Console.ReadLine());
         
         a13.media=(a13.nota1+a13.nota2)/2;
         if (a13.media>=7)
         {
         	a13.situacao="Aprovado";
         }
         else
         {
         	a13.situacao="Reprovado";
         }	
         	
         Console.WriteLine("Digite o nome do 14° aluno:");
         a14.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 14° aluno:");
         a14.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 14° aluno:");
         a14.nota2=double.Parse(Console.ReadLine());
         
         a14.media=(a14.nota1+a14.nota2)/2;
         if (a14.media>=7)
         {
         	a14.situacao="Aprovado";
         }
         else
         {
         	a14.situacao="Reprovado";
         }
         
         Console.WriteLine("Digite o nome do 15° aluno:");
         a15.aluno=Console.ReadLine();
         Console.WriteLine("Digite a 1°nota do 15° aluno:");
         a15.nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a 2°nota do 15° aluno:");
         a15.nota2=double.Parse(Console.ReadLine());
         
         a15.media=(a15.nota1+a15.nota2)/2;
         if (a15.media>=7)
         {
         	a15.situacao="Aprovado";
         }
         else
         {
         	a15.situacao="Reprovado";
         }	
         
         Console.WriteLine("RELAÇÃO DOS ALUNOS:");
         
         if (a1.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a1.aluno+ "|" +a1.nota1+ "|" +a1.nota2+ "|" +a1.media+ "|" +a1.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a1.aluno+ "|" +a1.nota1+ "|" +a1.nota2+ "|" +a1.media+ "|" +a1.situacao);
         }
         
         if (a2.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a2.aluno+ "|" +a2.nota1+ "|" +a2.nota2+ "|" +a2.media+ "|" +a2.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a2.aluno+ "|" +a2.nota1+ "|" +a2.nota2+ "|" +a2.media+ "|" +a2.situacao);
         }
         
         if (a3.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a3.aluno+ "|" +a3.nota1+ "|" +a3.nota2+ "|" +a3.media+ "|" +a3.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a3.aluno+ "|" +a3.nota1+ "|" +a3.nota2+ "|" +a3.media+ "|" +a3.situacao);
         }
         
         if (a4.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a4.aluno+ "|" +a4.nota1+ "|" +a4.nota2+ "|" +a4.media+ "|" +a4.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a4.aluno+ "|" +a4.nota1+ "|" +a4.nota2+ "|" +a4.media+ "|" +a4.situacao);
         }
         
         if (a5.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a5.aluno+ "|" +a5.nota1+ "|" +a5.nota2+ "|" +a5.media+ "|" +a5.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a5.aluno+ "|" +a5.nota1+ "|" +a5.nota2+ "|" +a5.media+ "|" +a5.situacao);
         }
         
         if (a6.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a6.aluno+ "|" +a6.nota1+ "|" +a6.nota2+ "|" +a6.media+ "|" +a6.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a6.aluno+ "|" +a6.nota1+ "|" +a6.nota2+ "|" +a6.media+ "|" +a6.situacao);
         }
         
         if (a7.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a7.aluno+ "|" +a7.nota1+ "|" +a7.nota2+ "|" +a7.media+ "|" +a7.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a7.aluno+ "|" +a7.nota1+ "|" +a7.nota2+ "|" +a7.media+ "|" +a7.situacao);
         }
         
         if (a8.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a8.aluno+ "|" +a8.nota1+ "|" +a8.nota2+ "|" +a8.media+ "|" +a8.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a8.aluno+ "|" +a8.nota1+ "|" +a8.nota2+ "|" +a8.media+ "|" +a8.situacao);
         }
         
         if (a9.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a9.aluno+ "|" +a9.nota1+ "|" +a9.nota2+ "|" +a9.media+ "|" +a9.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a9.aluno+ "|" +a9.nota1+ "|" +a9.nota2+ "|" +a9.media+ "|" +a9.situacao);
         }
         
         if (a10.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a10.aluno+ "|" +a10.nota1+ "|" +a10.nota2+ "|" +a10.media+ "|" +a10.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a10.aluno+ "|" +a10.nota1+ "|" +a10.nota2+ "|" +a10.media+ "|" +a10.situacao);
         }
         
         if (a11.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a11.aluno+ "|" +a11.nota1+ "|" +a11.nota2+ "|" +a11.media+ "|" +a11.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a11.aluno+ "|" +a11.nota1+ "|" +a11.nota2+ "|" +a11.media+ "|" +a11.situacao);
         }
         
         if (a12.situacao=="Aprovado")
         { 
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a12.aluno+ "|" +a12.nota1+ "|" +a12.nota2+ "|" +a12.media+ "|" +a12.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a12.aluno+ "|" +a12.nota1+ "|" +a12.nota2+ "|" +a12.media+ "|" +a12.situacao);
         }
         
         if (a13.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a13.aluno+ "|" +a13.nota1+ "|" +a13.nota2+ "|" +a13.media+ "|" +a13.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
            Console.WriteLine(a13.aluno+ "|" +a13.nota1+ "|" +a13.nota2+ "|" +a13.media+ "|" +a13.situacao);
         }
         
         if (a14.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a14.aluno+ "|" +a14.nota1+ "|" +a14.nota2+ "|" +a14.media+ "|" +a14.situacao);
         }
         else
         {
         	Console.ForegroundColor=
            ConsoleColor.Red;
         	Console.WriteLine(a14.aluno+ "|" +a14.nota1+ "|" +a14.nota2+ "|" +a14.media+ "|" +a14.situacao);
         }
         
         if (a15.situacao=="Aprovado")
         {
         	Console.ForegroundColor=
         	ConsoleColor.Blue;
         	Console.WriteLine(a15.aluno+ "|" +a15.nota1+ "|" +a15.nota2+ "|" +a15.media+ "|" +a15.situacao);
         }
         else
         {
         	Console.ForegroundColor=
         	ConsoleColor.Red;
         	Console.WriteLine(a15.aluno+ "|" +a15.nota1+ "|" +a15.nota2+ "|" +a15.media+ "|" +a15.situacao);
         }
         */
         
        }
        
        
        
        
        
    }
}