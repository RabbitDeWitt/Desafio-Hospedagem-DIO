using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Interfaces
{
    public interface IReserva
    {
        void CadastrarHospedes(List<Pessoa> hospedes);
        void CadastrarSuite(Suite suite);
        int ObterQuantidadeHospedes();
        decimal CalcularValorDiaria();
    }
}
