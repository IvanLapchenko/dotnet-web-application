using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepostory TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public INewsItemsRepository NewsItems { get; set; }

        public DataManager(ITextFieldsRepostory textFieldsRepostory, IServiceItemsRepository serviceItemsRepository, INewsItemsRepository newsItemsRepository)
        {
            TextFields = textFieldsRepostory;
            ServiceItems = serviceItemsRepository;
            NewsItems = newsItemsRepository;
        }
    }
}
