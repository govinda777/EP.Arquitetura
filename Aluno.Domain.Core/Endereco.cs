namespace Aluno.Domain.Core
{
    public class Endereco
    {
        public AlunoId AlunoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
    }
}