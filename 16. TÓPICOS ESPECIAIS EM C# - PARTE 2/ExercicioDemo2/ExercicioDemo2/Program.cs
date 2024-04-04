namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Good morning!";
            string explain = "This program limits a given string to 10 caracters by using Extensios. The class 'String', from the method 'Cut' is responsible " +
                "for that.";

            Console.WriteLine(s1.Cut(10));
            Console.WriteLine(explain.Cut(10));

            string s2 = "\nBom dia!";
            string explica = "Esse programa limita uma dada string a 10 caracteres através do uso de Extensions. O responsável por isso é o método 'Cut'," +
                "da classe 'String'.";

            Console.WriteLine(s2.Cut(10));
            Console.WriteLine(explica.Cut(10));

        }
    }
}
