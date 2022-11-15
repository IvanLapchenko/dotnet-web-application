using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Entities
{
    public class Message
    {
        public string Title { get; set; }
        public string CodeWord { get; set; }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Your message")]
        public string Text { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
