using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{ public class GroupData
    {
        private string name;
        private string header="";
        private string footer="";

        public GroupData(string name)//конструктор
        {
            this.name = name;
        }
        public GroupData(string name, string header, string footer)//конструктор
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }
        public string Name//свойство
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    public string Header
    {
        get
        {
            return header;
        }
        set
        {
            header = value;
        }
    }
    public string Footer
    {
        get
        {
            return footer;
        }
        set
        {
            footer = value;
        }
    }
    }
}
