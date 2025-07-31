using Freelancer_Marketplace.DTOs;
using Freelancer_Marketplace.Models;
using Microsoft.EntityFrameworkCore;

namespace Freelancer_Marketplace.Services
{
    public class ClientService : IClientService
    {   
        private readonly FreelancerDbContext _context;
        public ClientService(FreelancerDbContext context) {
        _context = context;
        }
        public async Task<IEnumerable<ClientDTO>> GetAllClientsAsync()
        {
            return await _context.Clients.Select(c => new ClientDTO
            {
                ClientId = c.ClientId,
                Name = c.Name,
                Email = c.Email
            }).ToListAsync();
        }

    }
}
