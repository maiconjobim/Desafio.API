using Domian.Commands.Responses;
using MediatR;

namespace Domian.Commands.Requests
{
    public class CalculaJurosRequest : IRequest<CalculaJurosResponse>
    {
        public double ValorInicial { get; set; }
        public int Meses { get; set; }
    }
}