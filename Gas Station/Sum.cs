using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station
{
    class Sum:INotifyPropertyChanged
    {
        private int summa;

        public int Summa
        {
            get { return summa; }
            set
            {
                summa = value;
                OnPropertyChanged("Summa");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    
}
