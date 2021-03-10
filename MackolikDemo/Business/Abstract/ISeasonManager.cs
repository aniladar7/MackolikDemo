using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISeasonManager
    {
        List<Season> GetList(Expression<Func<Season, bool>> filter = null);
        Season Get(Expression<Func<Season, bool>> filter);
        void Add(Season season);
        void Update(Season season);
        void Delete(Season season);
    }
}
