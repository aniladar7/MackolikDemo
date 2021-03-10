using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRefereeManager
    {
        List<Referee> GetList(Expression<Func<Referee, bool>> filter = null);
        Referee Get(Expression<Func<Referee, bool>> filter);
        void Add(Referee referee);
        void Update(Referee referee);
        void Delete(Referee referee);
    }
}
