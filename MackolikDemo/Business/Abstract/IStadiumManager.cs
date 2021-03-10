using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStadiumManager
    {
        List<Stadium> GetList(Expression<Func<Stadium, bool>> filter = null);
        Stadium Get(Expression<Func<Stadium, bool>> filter);
        void Add(Stadium stadium);
        void Update(Stadium stadium);
        void Delete(Stadium stadium);
    }
}
