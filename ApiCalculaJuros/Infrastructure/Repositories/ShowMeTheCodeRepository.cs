using System.Threading.Tasks;
using Domian.Respositories;

namespace Infrastructure.Repositories
{
    public class ShowMeTheCodeRepository : IShowMeTheCodeRepository
    {
        private const string link = "https://github.com/maiconjobim/Desafio.Api";

        public Task<string> GetLink()
        {
            return Task.FromResult(link);
        }
    }
}