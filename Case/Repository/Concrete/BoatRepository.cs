using Case.Context;
using Case.Models;
using Case.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Repository.Concrete
{
    public class BoatRepository : BaseRepository<Boat, AppDbContext>, IBoatRepository
    {
        public BoatRepository(AppDbContext dbContext):base(dbContext)
        {

        }
    }
}
