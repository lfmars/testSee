using JsonToList.Models.DTO;
using JsonToList.Utils;
using JsonToList.Utils.imp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToList
{
  class Program
  {
    static void Main(string[] args)
    {
      //String word = "respublika";
      //String cutWord = word.Substring(2, word.Length-3);
      //Console.WriteLine(cutWord);
      //System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
      //dtDateTime = dtDateTime.AddSeconds(1516023614).ToLocalTime();
      // 1446756563007
      //Console.WriteLine(dtDateTime);
      // string pathName = Path.GetFullPath("doctagvons.json");
      //Console.WriteLine(pathName);

      //string fileName = "";
      //FileInfo f = new FileInfo(fileName);
      //string fullname = f.FullName;
      //Console.WriteLine(fullname);
      StreamReader reader = new StreamReader(@"C:\Users\Marius\source\DbAction\testSee\JsonToList\Sources\examples.json");
      string json = reader.ReadToEnd();

      List<DTOexamples> exampls = JsonConvert.DeserializeObject<List<DTOexamples>>(json);
            IJsonToDatabase worker = new JsonToDatabaseImp();
            //done
            worker.examples(exampls);




      Console.WriteLine(exampls.Count);


      //StringToDate sToDate = new StringToDateImp();
     
     //string dat = versions[0].CreationDate;
     //DateTime time  = sToDate.GetDate(dat);
      //Console.WriteLine(time);
      //for (int i = 0; i < 10; i++)
      //{
      //  Math.Max(3, 4);
      //}
      //dynamic array = JsonCo0nvert.DeserializeObject(json);
      //foreach (var item in array)
      //{
      //  Console.WriteLine("{}", item.Name);
      //}
      // Console.WriteLine("\/Date(1446756563007-0500)\/");
    }
  }
}
