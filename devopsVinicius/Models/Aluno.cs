namespace devopsVinicius.Models
{
    public class Aluno
    {
        public Aluno()
        {
            
        }
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Rgm { get; set; }
        public string? Professor { get; set; }
        public string? Email { get; set; }
        public DateTime Idade { get; set; }
    }
}
