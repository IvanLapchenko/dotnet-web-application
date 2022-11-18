using System;
using System.Linq;
using WebApp.Domain.Repositories.Abstract;
using WebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFNewsItemRepository : INewsItemsRepository
    {
        private readonly AppDbContext context;

        public EFNewsItemRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<NewsItem> GetNewsItems()
        {
                return context.NewsItems;
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveNewsItem(NewsItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteNewsItem(Guid id)
        {
            context.NewsItems.Remove(new NewsItem() { Id = id });
            context.SaveChanges();
        }
    }
}
