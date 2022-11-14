using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Fill the name of the service")]
        [Display(Name = "Name of service")]
        public override string Title { get; set; }

        [Display(Name = "Short name of service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of service")]
        public override string Text { get; set; }

    }
}
