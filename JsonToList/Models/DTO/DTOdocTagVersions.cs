using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToList.Models.DTO
{
  class DTOdocTagVersions
  {
   public int Id { get; set; }
   public int DocTagId { get; set; }
   public String Name { get; set; }
   public String CreationDate { get; set; }
   public String LastEditDate { get; set; }
   public int LastEditUserId { get; set; }
   public String ReleaseDate { get; set; }
  }
}
