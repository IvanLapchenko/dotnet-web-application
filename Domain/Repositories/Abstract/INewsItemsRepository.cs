using System;
using System.Linq;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface INewsItemsRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        NewsItem GetNewsItemById(Guid id);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(Guid id);
    }
}
