using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{
    class Client
    {
        //Class => Field
        int id;
        public string name, surname;

        //Class => Property
        private string emailAddress;
        public string EmailAddress 
        { 
            //get;//Database veyafarklı bir veri kaynağı class çağıran programcıya datayı gösterdiğimiz alan
            //set;//Dış dünyadan alınan datanın içerisinde private olarak saklanan field içerisine değer atandığı kısım
        
            set
            {
                this.emailAddress = value;
            }
            get
            {
                return this.emailAddress;
            }
        
        }
    }
}
