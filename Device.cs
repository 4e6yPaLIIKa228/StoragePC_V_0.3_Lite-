using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoragePC
{
    public class Device : INotifyPropertyChanged
    {
        private string description;
        private string type;
        private string kabunet;
        private int number; 

        public int Id { get; set; }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public string Kabunet
        {
            get { return kabunet; }
            set
            {
                kabunet = value;
                OnPropertyChanged("Kabunet");
            }
        }
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
