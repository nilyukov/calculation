using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System;

namespace MVVM
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Calculation selectedCalculation;
        public ObservableCollection<Calculation> Calculations { get; set; }

        private RelayCommand calcCommand; 
        public RelayCommand CalcCommand
        {
            get
            {
                return calcCommand ??
                    (calcCommand = new RelayCommand(obj =>
                    {
                        Calculation calc = obj as Calculation;

                        if (calc != null)
                        {
                            Console.Write(calc);
                        
                        }
                    },
                    (obj) => Calculations.Count > 0));
            }
        }

     
        public Calculation SelectedCalculation
        {
            get { return selectedCalculation; }
            set
            {
                selectedCalculation = value;
                OnPropertyChanged("SelectedCalculation");
            }
        }

        public ApplicationViewModel()
        {
            Calculations = new ObservableCollection<Calculation>
            {
                new Calculation { Id=1, Name="Substance A", ConcVal=10, RefVal=20},
                new Calculation { Id=2, Name="Substance B", ConcVal=15, RefVal=30},
               
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}