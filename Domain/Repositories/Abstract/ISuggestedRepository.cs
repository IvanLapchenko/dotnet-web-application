using System;
using System.Linq;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface ISuggestedRepository
    {
        IQueryable<Suggested> GetSuggested();
        Suggested GetSuggestedById(Guid id);
        void SaveSuggested(Suggested entity);
        void DeleteSuggested(Guid id);
    }
}
