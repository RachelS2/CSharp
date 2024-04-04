/*Exe02 - DEMO StringBuilder. Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do
terminal, conforme exemplo. */
using ExeRes02.Entidades;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip"); 
            Comment c2 = new Comment("Wow that's awesome!");

            DateTime data = DateTime.Parse("21/06/2018 13:05:44");
            Post novo = new Post(data, "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
            novo.AddComentario(c1);
            novo.AddComentario(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post novo2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            novo2.AddComentario(c3);
            novo2.AddComentario(c4);

            Console.WriteLine(novo); 
            Console.WriteLine(novo2);
        }
    }
}

