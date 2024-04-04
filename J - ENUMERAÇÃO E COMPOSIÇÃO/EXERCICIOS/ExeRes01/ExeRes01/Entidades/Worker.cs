using Course;
using ExeRes01.Entidades.Enums;
using ExeRes01.Entidades;

namespace ExeRes01
{
    internal class Worker
    {
        public string nomeTrabalhador { get; set; }
        public double baseSalary { get; set; }
        public WorkerLevel Nivel { get; set; } //nível do trabalhador vem do enum WorkerLevel
        public Department Department { get; set; } //associação entre Worker e Department.
        public List<HourContract> Contract { get; set; } = new List<HourContract>(); //lista de Contratos. Um trabalhador tem vários contratos. O "new" garante que a lista não seja nula

        public Worker() { } //construtor padrão

        public Worker(string nomet, double salarioBase, WorkerLevel level, Department department) //Construtor de Worker. Listas não são incluídas.
        {
            nomeTrabalhador = nomet;
            baseSalary = salarioBase;
            Department = department;
            Nivel = level;
        }

        public void AdicionaContrato(HourContract contrato)
        {
            Contract.Add(contrato); //adiciona um novo contrato na lista de contratos
        }

        public void RemoveContrato(HourContract contrato)
        {
            Contract.Remove(contrato);
        }

        public double Income(int year, int month) //retorna o salário total recebido através de um determinado ano e mês
        {
            double sum = baseSalary; //mesmo que o trabalhador não tenha contratos, ele recebe um salário mensal
            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) 
                    sum += contract.totalValue();
            }
            return sum;

        }
    }
}

