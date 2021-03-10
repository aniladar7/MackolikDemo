﻿using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class TeamStatistic:IEntity
    {
        public int Id { get; set; }
        public int Point { get; set; }
        public List<Team>  Teams { get; set; }
        public int MatchNumber { get; set; }
        public int VictoryNumber { get; set; }
        public int DefeatNumber { get; set; }
        public int PlusGoalNumber { get; set; }
        public int SourGoalNumber { get; set; }
        public int Avarage { get; set; }

    }
}
