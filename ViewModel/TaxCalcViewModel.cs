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


        public TaxCalcViewModel()
        {
            _ergebnis = new Ergebnis();
            ConfirmCommand = new Command(() => CanConfirm());
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
                ((Command)ConfirmCommand).ChangeCanExecute();
            }
        }

        private bool CanConfirm()
        {
            return SelectedPickerItem != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
