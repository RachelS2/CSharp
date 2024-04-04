namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> election = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int number = Convert.ToInt32(line[1]);

                        if (!election.ContainsKey(name))
                        {
                            election.Add(name, number);
                            election[name] = number;
                        }
                        else
                            election[name] += number;
                    }
                }
                foreach (KeyValuePair<string, int> pair in election)
                {
                    Console.WriteLine(pair.Key + ": " + pair.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
