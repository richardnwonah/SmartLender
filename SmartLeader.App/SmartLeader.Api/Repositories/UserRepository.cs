using Microsoft.EntityFrameworkCore;
using SmartLeader.Api.Data;
using SmartLeader.Api.Models;

namespace SmartLeader.Api.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.Include(u => u.CreditScore).ToListAsync();  
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.Include(u => u.CreditScore)
                .FirstAsync(u => u.Id == id);
        }

        public async Task AddAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
