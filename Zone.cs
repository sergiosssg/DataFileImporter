using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public class Zone
    {
        public string Name
        {
            get;
            set;
        }
    }

    public class ZoneTagPool
    {
        public static IDictionary<string, string> DictionaryOfZoneTags = new Dictionary<string, string>();


        static ZoneTagPool()
        {
            DictionaryOfZoneTags.Add("00","Сумы");
        }


    }



}
