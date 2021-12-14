using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tipos de Variaveis em C#
            int - Numeros ineiros postivios e negativos;
            flaot - um numero que pode conter . como 15.5;
            bool - verdadeiro ou falso;
            string - identificado com "", no caso textos "Hello World";
            Char - 'a' unica letra ou caracter*/
/* Primeiro programa que repete nomes com o foreach
String[] AlunosNovos = {"Carol", "José", "Paulo", "Daniel",
    "Darcy", "Felipe", "Everton", "Daniela", "Suelen"};

foreach (String Welcome in AlunosNovos)
{
    Console.WriteLine("Sejam bem vindos(a)" + Welcome + "!");
}
Console.ReadLine();*/



/* 2 programa - Controlador de velocidade
int contador = 0;
while (contador < 200)
{
    Console.WriteLine("O veiculo está a: " + contador + "km/h");
    contador++;

    Console.WriteLine("Este carro atingiu o limite maximo permitido nesta pista");
    Console.ReadLine();
}*/

/* 3 Programa - Avisa o horario de funcionamento do estabelecimento

int hora = 7;

while (hora >= 7 && hora <= 19) {            {
    Console.WriteLine("São:" + hora + "Horas" + "| O mercado está aberto !");
}
Console.WriteLine("O MERCADO ACABOU DE FECHAR" + "Nosso horario de funcionamento é das 7hrs as 19hrs");
Console.ReadLine(); */



/* 4 programa - Escolhe sabor de pizza e manda a mensagem de aproveitar 

String[] Cardápio =
{
    "Mussarela", "quatro queijos", "catupiry com bacon", "frango com catupiry", "cinco queijos", "Calabresa",
    "tradicional portuguesa", "Alho e Oleo"
};

foreach (String Sabor in Cardápio)
{
    Console.WriteLine("Temos o sabor : " + Sabor + "|Aproveite sua Pizza!");
}
Console.ReadLine(); */



/* 5 programa - Contagem regressiva de mil para lancamento de nave

Console.WriteLine("A contagem regressiva de lançamento foi iniciada");
for (int contador = 1000; contador >0; contador--)
{
   Console.WriteLine("Contando : " + contador);
}
Console.WriteLine("and retork to space");
Console.ReadLine(); */
}
}
}
