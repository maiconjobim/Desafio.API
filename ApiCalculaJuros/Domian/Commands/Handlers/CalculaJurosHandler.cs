using System;
using System.Threading;
using System.Threading.Tasks;
using Domian.Commands.Requests;
using Domian.Commands.Responses;
using Domian.Respositories;
using MediatR;

namespace Domian.Commands.Handlers
{
    public class CalculaJurosHandler : IRequestHandler<CalculaJurosRequest, CalculaJurosResponse>
    {
        ICalculaJurosRepository repository;

        public CalculaJurosHandler(ICalculaJurosRepository repository)
        {
            this.repository = repository;
        }

        public async Task<CalculaJurosResponse> Handle(
            CalculaJurosRequest request,
            CancellationToken cancellationToken) 
        {
            var juros = await repository.getTaxa();
            if(juros == -1){
                return new CalculaJurosResponse{Result = -1,Status = "Error"};
            }
            var value = request.ValorInicial * (Math.Pow((1+juros) , request.Meses));
            var finalValue = Math.Truncate(value * 100)/100; 
            return new CalculaJurosResponse {Result = finalValue , Status = "Success"};
        }
    }
}