using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PlayerStatistic:IEntity
    {

        public int Id { get; set; }
        public int GoalNumber { get; set; }
        public int AsistNumber { get; set; }
        public int YellowCardCount { get; set; }
        public int RedCartCount { get; set; }
        public int InjuryNumber { get; set; }
        public int MatchNumber { get; set; }
        public List<Player>  Players { get; set; }
    }
}
