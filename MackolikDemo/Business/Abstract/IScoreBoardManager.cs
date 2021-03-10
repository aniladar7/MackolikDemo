using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IScoreBoardManager
    {
        List<ScoreBoard> GetList(Expression<Func<ScoreBoard, bool>> filter = null);
        ScoreBoard Get(Expression<Func<ScoreBoard, bool>> filter);
        void Add(ScoreBoard scoreBoard);
        void Update(ScoreBoard scoreBoard);
        void Delete(ScoreBoard scoreBoard);
    }
}
