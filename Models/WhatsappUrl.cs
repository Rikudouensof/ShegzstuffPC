using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShegzstuffPC.Models
{
    class WhatsappUrl : INotifyPropertyChanged
    {
        private string zewhatsappurl;

        public WhatsappUrl()
        {

        }
        public WhatsappUrl(string zewhatsappurl)
        {
            ZeWhatsappUrl = zewhatsappurl;
        }


        public string ZeWhatsappUrl
        {
            set
            {
                if (zewhatsappurl != value)
                {
                    zewhatsappurl = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
                            new PropertyChangedEventArgs("ZeWhatsappUrl"));

                    }
                }
            }
            get
            {
                return zewhatsappurl;
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
