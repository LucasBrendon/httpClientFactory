using HttpClientFactoryDemo.Models;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services.Interfaces
{
    public interface IViaCepHttpService
    {
        Task<Endereco> ConsultarEndereco(int cep);
    }
}
