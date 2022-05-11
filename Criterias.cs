using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public interface ICriteriaTelefonOperator
    {
        public string TelefonOperator
        {
            get;
            set;
        }

        public string FileName
        {
            get;
            set;
        }


    }

    public interface ICriteriaPhoneNumber
    {
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
