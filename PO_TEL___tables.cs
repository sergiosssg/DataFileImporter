using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public class PO_TEL_VID_CONNECT
    {
        public int IDConnect
        { // ID_CONNECT   - идентификатор вида связи
            get;
            set;
        }

        public string KodOfConnect
        { // KOD_CONNECT  - код вида связи
            get;
            set;
        }

        public string NameOfConnect
        { // MAME_CONNECT - наименование связи
            get;
            set;
        }


        public PO_TEL_VID_CONNECT() 
        {
            this.IDConnect = 0;
            this.KodOfConnect = string.Empty;
            this.NameOfConnect = string.Empty;
        }

    }


    public class PO_TEL_OPERATOR
    { //
        public int IDOperator
        { // ID_OPERATOR  - идентификатор операторв связи
            get;
            set;
        }

        public string KodOfOperator
        { // KOD_OPERATOR - код оператора связи
            get;
            set;
        }

        public string NameOfOperator
        { // NAME_OPERATOR - наименование оператора связи
            get;
            set;
        }

        public int ID_BK
        { // ID_BK - идентификатор бюджет кода
            get;
            set;
        }

        public PO_TEL_VID_CONNECT ParentIDConnect
        { // ID_CONNECT  ссылка на вид связи
            get;
            set;
        }

        public int IDKagent
        { // ID_KAGENT  - идентификатор контрагента
            get;
            set;
        }

        public string NumberOfContract
        { // NOM_DOG  - номер договора
            get;
            set;
        }

        public DateTime DateOfContract
        { // DATE_DOG - дата договора
            get;
            set;
        }

    }
}
