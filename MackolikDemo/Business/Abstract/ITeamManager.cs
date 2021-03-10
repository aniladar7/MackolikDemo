using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamManager
    {
        List<Team> GetList(Expression<Func<Team, bool>> filter = null);
        Team Get(Expression<Func<Team, bool>> filter);
        void Add(Team team);
        void Update(Team team);
        void Delete(Team team);
    }
}
