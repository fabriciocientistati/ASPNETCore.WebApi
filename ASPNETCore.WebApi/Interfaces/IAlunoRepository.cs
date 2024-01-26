using ASPNETCore.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETCore.WebApi.Interfaces
{
    public interface IAlunoRepository
    {
        void Create(Tbaluno aluno);
        void Update(Tbaluno aluno);
        void Delete(int id);
        Task<Tbaluno> SelectByPk(int id);
        Task<IEnumerable<Tbaluno>> SelectAll();
        Task<bool> SaveAllAsync();
    }
}
