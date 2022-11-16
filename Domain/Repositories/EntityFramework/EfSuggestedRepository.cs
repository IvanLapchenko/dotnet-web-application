using WebApp.Domain.Repositories.Abstract;
using WebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EfSuggestedRepository : ISuggestedRepository
    {
        private readonly AppDbContext context;
        public EfSuggestedRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Suggested> GetSuggested()
        {
            return context.Suggested;
        }

        public Suggested GetSuggestedById(Guid id)
        {
            return context.Suggested.FirstOrDefault(x => x.Id == id);
        }

        public void SaveSuggested(Suggested entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteSuggested(Guid id)
        {
            context.Suggested.Remove(new Suggested() { Id = id });
            context.SaveChanges();
        }
    }
}
