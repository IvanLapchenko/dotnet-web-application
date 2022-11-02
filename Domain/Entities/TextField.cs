using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name | Header")]
        public override string Title { get; set; } = "Info Page";

        [Display(Name = "Contents")]
        public override string Text { get; set; } = "Content is filling by administrator";
    }
}
