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
    public class PlayerStatisticManager:IPlayerStatisticManager
    {
        IPlayerStatisticDal _playerStatisticDal;

        public PlayerStatisticManager(IPlayerStatisticDal playerStatisticDal)
        {
            _playerStatisticDal = playerStatisticDal;
        }

        public void Add(PlayerStatistic playerStatistic)
        {
            _playerStatisticDal.Add(playerStatistic);
        }

        public void Delete(PlayerStatistic playerStatistic)
        {
            _playerStatisticDal.Delete(playerStatistic);
        }

        public PlayerStatistic Get(Expression<Func<PlayerStatistic, bool>> filter)
        {
            return _playerStatisticDal.GetById(filter);
        }

        public List<PlayerStatistic> GetList(Expression<Func<PlayerStatistic, bool>> filter = null)
        {
            return _playerStatisticDal.GetAll(filter);
        }

        public void Update(PlayerStatistic playerStatistic)
        {
            _playerStatisticDal.Update(playerStatistic);
        }
    }
}
