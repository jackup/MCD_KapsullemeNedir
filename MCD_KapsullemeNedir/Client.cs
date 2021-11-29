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

        public Client()
        {
            this.id = CreateId();
        }

        

        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }
        public string name, surname;

        public string Surname
        {
            get { return this.surname; }
            set
            {
                this.surname = value;
                this.emailAddress = string.Format("{0}.{1}@hotmail.com", name, surname);
            }
        }

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

        private int koko { get; set; }

        //Ara Odev
        private string tck;
        public string Tck
        {
            set
            {
                if (value.Length == 11)
                {
                    bool flag = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool characterCheck = char.IsNumber(value[i]);
                        if (characterCheck)
                        {
                            //sayısal değer demektir.
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("TC Kimlik numarası içerisindeki değerler sayısal olmalıdır!");
                    }
                    else
                    {
                        this.tck = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik numarası 11 haneli olmalıdır!");
                }
            }
            get { return tck.Substring(0, 3); }
            
        }


        private int CreateId()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }
    }
}








