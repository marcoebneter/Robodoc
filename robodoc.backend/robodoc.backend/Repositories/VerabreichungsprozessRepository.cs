﻿using robodoc.backend.Common;
using robodoc.backend.Data;
using Robodoc.Data.Models;

namespace robodoc.backend.Repositories
{
    public class VerabreichungsprozessRepository : BaseRepository, IRepository<Verabreichungsprozess>
    {
        public VerabreichungsprozessRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Verabreichungsprozess> GetAll()
        {
            return _dbContext.Verabreichungsprozesse;
        }

        public IEnumerable<Verabreichungsprozess> Get(Guid id)
        {
            return _dbContext.Verabreichungsprozesse.Where(v => v.Id.Equals(id));
        }

        public void Delete(Verabreichungsprozess entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Verabreichungsprozess Insert(Verabreichungsprozess entity)
        {
            throw new NotImplementedException();
        }

        public Verabreichungsprozess Update(Verabreichungsprozess entity)
        {
            throw new NotImplementedException();
        }
    }
}
