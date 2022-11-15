using WebApp.Domain.Repositories.Abstract;
using WebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EfMessageRepository : IMessageRepository
    {
        private readonly AppDbContext context;        
        
        public EfMessageRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Message> GetMessages()
        {
            return context.Messages;
        }

        public Message GetMessageById(Guid id)
        {
            return context.Messages.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMessage(Message entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteMessage(Guid id)
        {
            context.Messages.Remove(new Message() { Id = id });
            context.SaveChanges();
        }
    }
}
