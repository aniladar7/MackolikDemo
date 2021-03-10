using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Stadium:IEntity
    {
        public int Id { get; set; }
        public int CurrentFixtureId { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public int Capacity { get; set; }
        public Fixture CurrentFixture { get; set; }
    }
}
