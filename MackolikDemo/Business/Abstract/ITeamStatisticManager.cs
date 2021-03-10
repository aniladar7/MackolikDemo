using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamStatisticManager
    {
        List<TeamStatistic> GetList(Expression<Func<TeamStatistic, bool>> filter = null);
        TeamStatistic Get(Expression<Func<TeamStatistic, bool>> filter);
        void Add(TeamStatistic teamStatistic);
        void Update(TeamStatistic teamStatistic);
        void Delete(TeamStatistic teamStatistic);
    }
}
