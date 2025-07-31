using Freelancer_Marketplace.DTOs;

namespace Freelancer_Marketplace.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllClientsAsync();
    }
}
