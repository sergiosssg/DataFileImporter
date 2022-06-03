using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public class DataBaseFacilities
    {

    }

    public class DbAppContext :  DbContext
    {
        public DbAppContext()
        {
            ;
        }
    }
}
