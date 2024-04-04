namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> student = new HashSet<Student>();

            for (int i = 0; i < 3; i++)
            {
                char curso = 'x';
                if (i is 0)
                    curso = 'A';

                else if (i is 1)
                    curso = 'B';

                else if (i is 2)
                    curso = 'C';

                Console.Write($"How many students for course {curso}? ");
                int num = int.Parse(Console.ReadLine());

                try
                {
                    for (int a = 0; a < num; a++)
                    {
                        int id = int.Parse(Console.ReadLine());
                        student.Add(new Student(id));
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Total students: " + student.Count);

        }
    }
}
