using System;

//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
//exemplo.

namespace Exercicio3 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Código: ");
            int alcool = 0; int gasolina = 0; int diesel = 0;
                        int cod = int.Parse(Console.ReadLine());
            while (cod > 5 || cod < 1)
            {
                Console.WriteLine("Insira um código válido.");
                Console.Write("Código: ");
                cod = int.Parse(Console.ReadLine());
            }
            while (cod != 4)
            {

                if (cod == 1)
                    alcool = alcool + 1;

                else if (cod == 2)
                    gasolina = gasolina + 1;

                else if (cod == 3)
                    diesel = diesel + 1;
                Console.Write("Código: ");
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }

}