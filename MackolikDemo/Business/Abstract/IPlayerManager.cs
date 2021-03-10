using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlayerManager
    {
        List<Player> GetList(Expression<Func<Player, bool>> filter = null);
        Player Get(Expression<Func<Player, bool>> filter);
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
