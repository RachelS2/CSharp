namespace ExeRes02.Entidades
{
    class Comment
    {       
        public string Text { get; set; }
        public Comment() //construtor padrão
        {
            
        }

        public Comment (string text) //construtor com parâmetro
        {
            Text = text;
        }

    }
}
