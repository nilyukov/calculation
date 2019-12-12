using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    public class Calculation : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private int concVal;
        private int refVal;
        private double result;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int ConcVal
        {
            get { return concVal; }
            set
            {
                concVal = value;
                OnPropertyChanged("ConcVal");
            }
        }
        public int RefVal
        {
            get { return refVal; }
            set
            {
                refVal = value;
                OnPropertyChanged("RefVal");
            }
        }

        public double Result
        {
            get { return result; }
            set
            {
                double result = value;
                OnPropertyChanged("Result");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}