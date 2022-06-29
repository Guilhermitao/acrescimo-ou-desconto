using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acrescimo_ou_desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            int salario, caso;
            double acrescimo, desconto, desconto_resul, acrescimo_resul;

            do
            {
                Console.WriteLine("Digite o seu salario.");
                salario = int.Parse(Console.ReadLine());

                Console.WriteLine("Voce teve um acrescimo ou desconto?\r\n1=desconto.\r\n2=acrescimo.");
                caso = int.Parse(Console.ReadLine());

                switch (caso)
                {

                    case 1:
                        Console.WriteLine("Digite o seu desconto");
                        desconto = double.Parse(Console.ReadLine());

                        desconto_resul = (desconto / 100);

                        Console.WriteLine("seu salario teve um desconto de " + desconto + "%. O resultado do desconto= " + salario * desconto_resul);
                        Console.WriteLine("seu salario antigo: " + salario);
                        Console.WriteLine("seu salario atual com desconto: " + (salario - (salario * desconto_resul)));
                        break;

                    case 2:
                        Console.WriteLine("Digite o seu acrescimo");
                        acrescimo = double.Parse(Console.ReadLine());

                        acrescimo_resul = ((acrescimo / 100));

                        Console.WriteLine("seu salario teve um acrescimo de " + acrescimo + "%. O resultado do acrescimo= " + salario * acrescimo_resul);
                        Console.WriteLine("seu salario antigo: " + salario);
                        Console.WriteLine("seu salario atual com acrescimo: " + (salario * (acrescimo_resul + 1)));
                        break;
                }//switch case

                Console.WriteLine("deseja continuar?\r\ns ou S = continua\r\nQualquer outro botao sai");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S");
            Console.ReadKey();
        }
    }
}
