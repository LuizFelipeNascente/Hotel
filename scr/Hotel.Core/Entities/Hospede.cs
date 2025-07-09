using Hotel.Core.Enums;

namespace Hotel.Core.Entities;

public class HospedeReserva
{
    public Guid HospedeReservaId { get; set; }
    public Guid ReservaId { get; set; }
    public TipoHospede Tipo { get; set; }
    public Guid PessoaId { get; set; }
    public string Nome { get; set; }


    public Task DefinirNomeHospede()
    {
        return Task.CompletedTask;
    }
}