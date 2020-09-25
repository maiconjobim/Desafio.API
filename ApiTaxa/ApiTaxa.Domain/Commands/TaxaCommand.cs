using ApiTaxa.Shared.Commands;

namespace ApiTaxa.Domain.Commands
{
    public class TaxaCommand : ICommand
    {
        public float TaxaJuros { get;  set; }

        public void Validate()
        {
            // validate taxa 
        }
    }
}