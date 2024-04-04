using System.Globalization;
using ExercicioPropostoDois.Entidades;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data; ");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i') 
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contribuintes.Add(new PessoaFisica(health, nome, income));

                }

                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contribuintes.Add(new PessoaJuridica(numberOfEmployees, nome, income));

                }

            }
            Console.WriteLine();
            double total = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach (Contribuinte contribuinte in contribuintes)
            {
                Console.WriteLine(contribuinte.Nome + ": $ " + contribuinte.Tax().ToString("F2", CultureInfo.InvariantCulture));
                total = total + contribuinte.Tax();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}