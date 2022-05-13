using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public class ScannedSeed
    {
        public string TelefonOperator
        {
            get;
            set;
        }
        public AccountPeriodTime AccountPeriodTimeProperty
        {
            get;
            set;
        }
        public Zone ZoneProperty
        {
            get;
            set;
        }

        public string AcountOfGivenService
        {
            get;
            set;
        }

        public string FileNameOfDataSource
        {
            get;
            set;
        }

        public int IndexOfFileInChain
        {
            get;
            set;
        }

        /**
         *    e.g. :
         *  "1,3,5,6,7,8"
         * 
         */
        public string TypeOfSeed
        {
            get;
            set;
        }

        public string RawValueOfCell
        {
            get;
            set;
        }

        public int NumberOfStringInDocument
        {
            get;
            set;
        }

        public string NameOfStringInDocument
        {
            get;
            set;
        }

        public string ColumnOfCellInDocument
        {
            get;
            set;
        }

    }
}
