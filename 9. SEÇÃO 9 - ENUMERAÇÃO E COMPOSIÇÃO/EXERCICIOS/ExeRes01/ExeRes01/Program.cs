/* Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo
(próxima página).*/

using ExeRes01.Entidades.Enums; 
using ExeRes01;
using ExeRes01.Entidades;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string nomedepartamento = Console.ReadLine();
            Department d = new Department(nomedepartamento);

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string nometrabalhador = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel Nivel = Enum.Parse<WorkerLevel>(Console.ReadLine()); //transformando de string para Enum

            Console.Write("Base salary: ");
            double salariotrabalhador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker w = new Worker(nometrabalhador, salariotrabalhador, Nivel, d); //instanciando o trabalhador

            Console.Write("How many contracts to this worker? ");
            int contratos = int.Parse(Console.ReadLine());

            for (int i = 0; i < contratos; i++)
            {
                Console.WriteLine("Enter #{0} contract data: ", i + 1);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hora = int.Parse(Console.ReadLine());

                HourContract Contrato = new HourContract(data, valor, hora); //cria contrato pro trabalhador
                w.AdicionaContrato(Contrato); //adiciona contrato na lista de contratos do trabalhador
                Console.WriteLine();

            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2)); //armazena os caracteres 0 e 1 (MM) da string mesEAno
            int ano = int.Parse(mesEAno.Substring(3)); //armazena os caracteres de 3 em diante (YYYY) da string mesEano
            double recebido = w.Income(ano, mes);

            Console.WriteLine("Name: " + w.nomeTrabalhador);
            Console.WriteLine("Department: " + w.Department.nomeDepartamento);
            Console.WriteLine("Income for " + mesEAno + ": " + recebido.ToString("F2", CultureInfo.InvariantCulture));
        
    }
    } }
