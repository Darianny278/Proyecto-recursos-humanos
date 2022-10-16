using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_recursos_humanos.Repository
{
    public class UnitOfWork
    {
        private readonly DBProyectoFinalContext _context;

        public UnitOfWork(DBProyectoFinalContext context)
        {
            _context = context; 
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
