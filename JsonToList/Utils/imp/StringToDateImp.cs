using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToList.Utils.imp
{
  class StringToDateImp : StringToDate
  {
    public DateTime GetDate(string unix)
    {
      double unixTimestamp = fromStringToNumber(unix);
      System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
      dtDateTime = dtDateTime.AddSeconds(unixTimestamp).ToLocalTime();
      
      return dtDateTime;

    }

    private double fromStringToNumber(string unix)
    {
      string myNumber = unix.Substring(6);
      var a = unix.Substring(unix.IndexOf('(') + 1);
      var b = a.Substring(0, a.IndexOf(')'));
      var numberParts = b.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

      return Convert.ToDouble(numberParts[0].Substring(0, numberParts[0].Length - 3));
      //"/Date(1446695376637-0500)/"
    }
  }
}
