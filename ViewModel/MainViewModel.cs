using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Budget.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region mainviewmodel creation
        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

        #region properties
        private MainViewModel _mvm;
        public MainViewModel(MainViewModel mvm)
        {
            _mvm = mvm;
        }
        #endregion 

        #region methods
        //constructor
        public MainViewModel()
        {
            _mvm = this;
            BudgetViewModel BudgetVM = new BudgetViewModel(this);
        }
        #endregion



    }
}
