using BookOfHabitsMicroservice.Domain.Entity;
using BookOfHabitsMicroservice.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookOfHabitsMicroservice.Domain.Repository.Abstractions
{
    public interface IRoomRepository : IRepository<Room, Guid>
    {
    }
}
