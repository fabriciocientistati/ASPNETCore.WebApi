using ASPNETCore.WebApi.Interfaces;
using ASPNETCore.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore.WebApi.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ficaihmgContext _context;

        public AlunoRepository(ficaihmgContext context)
        {
            _context = context;
        }

        public void Create(Tbaluno aluno)
        {
            _context.Tbaluno.Add(aluno);
        }

        public void Delete(Tbaluno aluno)
        {
            _context.Tbaluno.Remove(aluno);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Tbaluno>> SelectAll()
        {
            return await _context.Tbaluno.ToListAsync();
        }

        public async Task<Tbaluno> SelectByPk(int id)
        {
            return await _context.Tbaluno.Where(x => x.AluId == id).FirstOrDefaultAsync();
        }
            
        public void Update(Tbaluno aluno)
        {
            _context.Entry(aluno).State = EntityState.Modified;
        }
    }
}
