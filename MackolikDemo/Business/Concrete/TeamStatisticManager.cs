using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeamStatisticManager:ITeamStatisticManager
    {
        ITeamStatisticDal _teamStatistic;

        public TeamStatisticManager(ITeamStatisticDal teamStatistic)
        {
            _teamStatistic = teamStatistic;
        }

        public void Add(TeamStatistic teamStatistic)
        {
            _teamStatistic.Add(teamStatistic);
        }

        public void Delete(TeamStatistic teamStatistic)
        {
            _teamStatistic.Delete(teamStatistic);
        }

        public TeamStatistic Get(Expression<Func<TeamStatistic, bool>> filter)
        {
            return _teamStatistic.GetById(filter);
        }

        public List<TeamStatistic> GetList(Expression<Func<TeamStatistic, bool>> filter = null)
        {
            return _teamStatistic.GetAll(filter);
        }

        public void Update(TeamStatistic teamStatistic)
        {
            _teamStatistic.Update(teamStatistic);
        }
    }
}
