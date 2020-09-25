using System.Threading.Tasks;

namespace Domian.Respositories
{
    public interface IShowMeTheCodeRepository
    {
         Task<string> GetLink ();
    }
}