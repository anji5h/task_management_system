using TaskManagementAPI.Data;
using TaskManagementAPI.Models;

namespace TaskManagementAPI.Services
{
    public class UnitOfWork : IDisposable
    {
        private readonly TaskDbContext _context;

        public UnitOfWork(TaskDbContext context)
        {
            _context = context;
        }

        private IGenericRepository<UserModel>? _userRepository;

        public IGenericRepository<UserModel> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new GenericRepository<UserModel>(_context);
                }

                return _userRepository;
            }

        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}