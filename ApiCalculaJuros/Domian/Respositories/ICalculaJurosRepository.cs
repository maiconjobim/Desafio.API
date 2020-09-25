using System.Threading.Tasks;

namespace Domian.Respositories
{
    public interface ICalculaJurosRepository
    {
        Task<double> getTaxa(); 
    }
}