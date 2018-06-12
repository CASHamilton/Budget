using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Budget.ViewModel
{
    public class BudgetViewModel : INotifyPropertyChanged
    {
        #region ViewModel Prepwork
        #region Constructor
        private readonly MainViewModel _mvm;
        public BudgetViewModel(MainViewModel mvm)
        {
            _mvm = mvm;
        }
        #endregion
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
        #endregion  //no need to edit anything in this region
        #region viewmodel creation

        private BudgetViewModel _budgetViewModel;
        public BudgetViewModel BudgetVM
        {
            get { return _budgetViewModel; }
            set
            {
                _budgetViewModel = value;
                OnPropertyChanged("BudgetVM");
            }
        }

        #endregion


        #region Properties



        #endregion
    }
}
