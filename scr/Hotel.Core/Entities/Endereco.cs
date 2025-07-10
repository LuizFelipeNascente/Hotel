namespace Hotel.Core.Entities;

public class Endereco : EntidadeBase
{
    public Guid EnderecoId { get; set; }
    public string Logradouro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Cep { get; set; }
    //public DetalhePessoa DetalhePessoa { get; set; }

    public void SetarEnderecoId() => EnderecoId = Guid.NewGuid();
}