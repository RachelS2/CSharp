//Fazer um programa para ler o caminho de um arquivo .csv
//contendo os dados de itens vendidos. Cada item possui um
//nome, preço unitário e quantidade, separados por vírgula. Você
//deve gerar um novo arquivo chamado "summary.csv", localizado
//em uma subpasta chamada "out" a partir da pasta original do
//arquivo de origem, contendo apenas o nome e o valor total para
//aquele item (preço unitário multiplicado pela quantidade),
//conforme exemplo

using System.IO;
using System.Text;
using System.Globalization;
using System;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @".\exefix.txt";
            string targetPath = @"C:\Users\rachels\source\repos\RachelS2\CSharp\13.SEÇÃO 13 - TRABALHANDO COM ARQUIVOS\exefix\exefix\exefix2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] linha = line.Split(',');
                        double valor = Convert.ToDouble(linha[1], CultureInfo.InvariantCulture);
                        int qtde = Convert.ToInt32(linha[2]);
                        double precoFinal = valor * qtde;
                        sw.WriteLine($"{linha[0]}, {precoFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}