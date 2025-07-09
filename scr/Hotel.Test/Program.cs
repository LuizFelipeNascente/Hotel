
using Hotel.Test.Methods;

class Program
{
    static async Task Main(string[] args)
    {
        CreatePerson createPerson = new CreatePerson();
        while (true)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Teste do metodo CreatePerson");
            Console.WriteLine("2 - Teste do metodo: ");
            Console.WriteLine("3 - Sair");
            Console.WriteLine(" ");
            Console.Write("Digite uma opção para executar: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var (pessoa, detalhe) = createPerson.AdicionarPessoaComDetalhes();
                    Console.WriteLine("\nPessoa criada com sucesso!");
                    Console.WriteLine($"ID: {pessoa.PessoaId}");
                    Console.WriteLine($"Nome: {pessoa.Nome} {pessoa.Sobrenome}");
                    Console.WriteLine($"RG: {pessoa.Rg.NumeroRg}");
                    Console.WriteLine($"CPF: {pessoa.Cpf.NumeroCpf}");
                    Console.WriteLine($"Tipo Pessoa: {pessoa.TipoPessoa}");
                    Console.WriteLine($"Nascimento: {pessoa.DataNascimento:dd/MM/yyyy}");

                    Console.WriteLine("\nDetalhes:");
                    Console.WriteLine($"Email: {detalhe.Email}");
                    Console.WriteLine($"Telefone: {detalhe.Telefone}");
                    Console.WriteLine($"EndereçoId: {detalhe.EnderecoId}");
                    break;
                case "2":
                    Console.WriteLine("Opção inválida, por favor escolha novamente.");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }    
}
