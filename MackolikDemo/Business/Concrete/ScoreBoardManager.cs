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
    public class ScoreBoardManager:IScoreBoardManager
    {
        IScoreBoardDal _scoreBoardDal;

        public ScoreBoardManager(IScoreBoardDal scoreBoardDal)
        {
            _scoreBoardDal = scoreBoardDal;
        }

        public void Add(ScoreBoard scoreBoard)
        {
            _scoreBoardDal.Add(scoreBoard);
        }

        public void Delete(ScoreBoard scoreBoard)
        {
            _scoreBoardDal.Delete(scoreBoard);
        }

        public ScoreBoard Get(Expression<Func<ScoreBoard, bool>> filter)
        {
            return _scoreBoardDal.GetById(filter);
        }

        public List<ScoreBoard> GetList(Expression<Func<ScoreBoard, bool>> filter = null)
        {
            return _scoreBoardDal.GetAll(filter);
        }

        public void Update(ScoreBoard scoreBoard)
        {
            _scoreBoardDal.Update(scoreBoard);
        }
    }
}
