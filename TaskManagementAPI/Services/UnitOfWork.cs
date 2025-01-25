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

        private IGenericService<UserModel>? _userService;

        public IGenericService<UserModel> UserService
        {
            get
            {
                if (_userService == null)
                {
                    _userService = new GenericService<UserModel>(_context);
                }

                return _userService;
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