using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToList.Models.See
{
  class DocTagsVersions
  {
    public long id { get; set; }
    public long doctagid { get; set; }
    public String title { get; set; }
    public DateTime creationDate { get; set; }
    public DateTime lastEditDate { get; set; }
  }
}
