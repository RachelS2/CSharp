/* Uma empresa possui funcionários próprios e terceirizados. Para cada funcionário, deseja-se registrar nome, horas
trabalhadas e valor por hora. Funcionários terceirizados possuem ainda uma despesa adicional.O pagamento dos funcionários 
corresponde ao valor da hora multiplicado pelas horas trabalhadas, sendo que os funcionários terceirizados ainda recebem 
um bônus correspondente a 110% de sua despesa adicional. Fazer um programa para ler os dados de N funcionários (N fornecido 
pelo usuário) e armazená-los em uma lista. Depois de ler todos os dados, mostrar nome e pagamento de cada funcionário na 
mesma ordem em que foram digitados. Construa o programa conforme projeto ao lado. Veja exemplo na próxima página. */

using ExercicioResolvidoUm.Entidades;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numeroDeFuncionarios = int.Parse(Console.ReadLine());

            List<Employee> funcionariosGlobal = new List<Employee>(); //criando lista de todos os funcionarios (terceirizados ou não)


            for (int i = 0; i < numeroDeFuncionarios; i++)
            {
                Console.WriteLine("Employee #{0} data: ", i+1);

                Console.Write("Outsourced (y/n)? ");
                char resposta = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nomeDoFuncionario = Console.ReadLine();

                Console.Write("Hours: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionariosGlobal.Add(new OutsourcedEmployee(nomeDoFuncionario, horasTrabalhadas, valorPorHora, additionalCharge));
                }
                else
                {
                    funcionariosGlobal.Add(new Employee(nomeDoFuncionario, horasTrabalhadas, valorPorHora));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in funcionariosGlobal)
            {
                Console.WriteLine(emp.Nome + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}




