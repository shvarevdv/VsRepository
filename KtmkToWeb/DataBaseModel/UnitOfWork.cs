using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModel
{
    public class UnitOfWork : IDisposable
    {
        private readonly ISFDSEntities2 _context = new ISFDSEntities2();
        private IRepository<NU> _nuRepository;
        public IRepository<NU> NURepository
        {
            get
            {
                return _nuRepository ?? (_nuRepository = new GenericRepository<NU>(_context));
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
