using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetUserRolesEntityFramework.Models
{
    public class DiscussionForum
    {
        public int Id { get; set; }
        [Display(Name = "Date")]

        public DateTime PostDate { get; set; }
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Heading")]
        public string Heading { get; set; }

        [Required]
        [Display(Name = "Restaurant")]
        public string TopicTitle { get; set; }

        [Required]
        [Display(Name = "Comment")]
        public string MessageContent { get; set; }

        [Required]
        [Range(0,5)]
        [Display(Name = "Rating")]
        public int Like { get; set; }

        [Required]
        [Display(Name = "Agree")]
        public int Agree { get; set; }

        [Required]
        [Display(Name = "Disagree")]
        public int Disagree { get; set; }

        public bool canAgree { get; set; }
        public DiscussionForum() 
        {
            canAgree = true;
            canDisagree = true;
        }

        public bool canDisagree { get; set; }
    }
}
