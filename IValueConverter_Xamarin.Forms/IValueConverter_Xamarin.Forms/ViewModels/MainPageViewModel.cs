using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IValueConverter_Xamarin.Forms.ViewModels {

    public class MainPageViewModel : INotifyPropertyChanged{

        private string season;
        public string Season {
            get { return season; }
            set { season = value;
                OnPropertyChanged("Season");
            }
        }

        public ICommand WinterSelected { get; private set; }
        public ICommand SpringSelected { get; private set; }
        public ICommand SummerSelected { get; private set; }
        public ICommand AutumnSelected { get; private set; }

        public MainPageViewModel() {

            WinterSelected = new Command(SetWinter);
            SpringSelected = new Command(SetSpring);
            SummerSelected = new Command(SetSummer);
            AutumnSelected = new Command(SetAutumn);
        }


        void SetWinter() {
            Season = "Winter";
        }

        void SetSpring() {
            Season = "Spring";
        }

        void SetSummer() {
            Season = "Summer";
        }

        void SetAutumn() {
            Season = "Autumn";
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
