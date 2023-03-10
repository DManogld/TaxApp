using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaxApp.Model;
using TaxApp.Views;

namespace TaxApp.ViewModel
{
    public class TaxCalcViewModel : INotifyPropertyChanged
    {
        public ICommand ConfirmCommand { get; private set; }
        private Ergebnis _ergebnis;
        private object _selectedPickerItem;
        private string _isNetto;
        public string IsNetto
        {
            get { return _isNetto; }
            set
            {
                _isNetto = value;
                OnPropertyChanged(nameof(IsNetto));
            }
        }

        private string _prozent;
        public string Prozent
        {
            get { return _prozent; }
            set
            {
                _prozent = value;
                OnPropertyChanged(nameof(Prozent));
            }
        }

        private string _betrag;
        public string Betrag
        {
            get { return _betrag; }
            set
            {
                _betrag = value;
                OnPropertyChanged(nameof(Betrag));
            }
        }

        public TaxCalcViewModel()
        {
            _ergebnis = new Ergebnis();

        }


        public Ergebnis Ergebnis
        {
            get { return _ergebnis; }
            set
            {
                _ergebnis = value;
                OnPropertyChanged(nameof(Ergebnis));
            }
        }

        public object SelectedPickerItem
        {
            get { return _selectedPickerItem; }
            set
            {
                _selectedPickerItem = value;
                OnPropertyChanged(nameof(SelectedPickerItem));

            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
          
        }
    }
}
