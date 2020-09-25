namespace ApiTaxa.Domain.Entities
{
    public class Taxa
    {
        
        public double TaxaJuros { get; private set; }

        public Taxa(double taxaJuros)
        {
            TaxaJuros = taxaJuros;
        }

    }
}