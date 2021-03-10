using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFixtureManager
    {
        List<Fixture> GetList(Expression<Func<Fixture,bool>>filter =null);
        Fixture Get(Expression<Func<Fixture,bool>>filter);
        void Add(Fixture fixture);
        void Update(Fixture fixture);
        void Delete(Fixture fixture);
    }
}
