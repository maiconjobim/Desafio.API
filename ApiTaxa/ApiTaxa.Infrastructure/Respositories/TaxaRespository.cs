

using ApiTaxa.Domain.Repositories;

namespace ApiTaxa.Infrastructure.Respositories
{
    public class TaxaRespository : ITaxaRespository
    {
        public double getTaxa()
        {
            return 0.01;
        }
    }
}