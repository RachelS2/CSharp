using System.Buffers;
using System.Text;

namespace ExeRes02.Entidades
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } //subtítulo

        public List<Comment> Comments { get; set; } = new List<Comment>(); //Lista de comentários, associação com outra classe

        public int Like { get; set; }

        public Post() { }
        public Post(DateTime moment, string title, string content, int like) //construtor com todos os parâmetros de post, exceto a lista
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;
        }

        public void AddComentario(Comment comentario)
        {
            Comments.Add(comentario);
        }

        public void RemoveComentario(Comment comentario)
        {
            Comments.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Like); 
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
