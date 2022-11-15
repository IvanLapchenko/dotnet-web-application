using System;
using System.Linq;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IMessageRepository
    {
        IQueryable<Message> GetMessages();
        Message GetMessageById(Guid id);
        void SaveMessage(Message entity);
        void DeleteMessage(Guid id);
    }
}
