using System.Text.RegularExpressions;

namespace Hotel.Core.Entities;

public class DetalhePessoa : EntidadeBase
{
    public Guid DetalhePessoaId { get; set; }
    public Guid PessoaId { get; set; }
    public Email Email { get; set; }
    public string Telefone { get; set; }
    
    public Guid EnderecoId { get; set; }
    //public Endereco Endereco { get; set; }
    //public Pessoa Pessoa { get; set; }
    
    public void SetarDetalhePessoaId() => DetalhePessoaId = Guid.NewGuid();
    
    public static bool ValidarTelefone(string telefone)
    {
        if (string.IsNullOrWhiteSpace(telefone))
            return false;

        telefone = Regex.Replace(telefone, "[^0-9]", "");

        return telefone.Length == 10 || telefone.Length == 11;
    }
}