using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlayerStatisticManager
    {
        List<PlayerStatistic> GetList(Expression<Func<PlayerStatistic, bool>> filter = null);
        PlayerStatistic Get(Expression<Func<PlayerStatistic, bool>> filter);
        void Add(PlayerStatistic playerStatistic);
        void Update(PlayerStatistic playerStatistic);
        void Delete(PlayerStatistic  playerStatistic);
    }
}
