using JsonToList.Models.DTO;
using JsonToList.Models.See;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToList.Utils
{
    interface IJsonToDatabase
    {
        void docTagsVersions(List<DTOdocTagVersions> docTagsVersions);

    }
}
