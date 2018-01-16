using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToList.Models.DTO
{
    class DTOexamples
    {
     public long Id { get; set; }
     public long DocTopicId { get; set; }
     public string Title { get; set; }
     public string CreationDate { get; set; }
     public string LastEditDate { get; set; }
     public long Score { get; set; }
     public long ContributorCount { get; set; }
     public string BodyHtml { get; set; }
     public string BodyMarkdown { get; set; }
     public bool IsPinned { get; set; }
    }
}
