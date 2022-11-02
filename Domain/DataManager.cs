using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepostory TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepostory textFieldsRepostory, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepostory;
            ServiceItems = serviceItemsRepository;
        }
    }
}
