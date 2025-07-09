using System.Text.RegularExpressions;

namespace Hotel.Core.Entities;

public class DetalhePessoa
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

        // Telefones celulares no Brasil: 11 dígitos (ex: 11987654321)
        // Telefones fixos: 10 dígitos (ex: 1132547890)
        return telefone.Length == 10 || telefone.Length == 11;
    }
}