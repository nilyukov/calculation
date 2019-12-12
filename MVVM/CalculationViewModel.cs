using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    public class CalculationViewModel : INotifyPropertyChanged
    {
        private Calculation calc;

        public CalculationViewModel(Calculation p)
        {
            calc = p;
        }

        public int Id
        {
            get { return calc.Id; }
            set
            {
                calc.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return calc.Name; }
            set
            {
                calc.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public int ConcVal
        {
            get { return calc.ConcVal; }
            set
            {
                calc.ConcVal = value;
                OnPropertyChanged("ConcVal");
            }
        }

        public int RefVal
        {
            get { return calc.RefVal; }
            set
            {
                calc.RefVal = value;
                OnPropertyChanged("RefVal");
            }
        }

        public double Result
        {
            get { return calc.Result; }
            set
            {
                calc.Result = value;
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