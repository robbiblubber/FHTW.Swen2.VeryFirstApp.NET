using System;
using System.Windows.Input;



namespace FHTW.Swen2.VeryFirstApp
{
    /// <summary>This class implements a greeting command.</summary>
    public class GreetingCommand: ICommand
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // private members                                                                                          //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Parent view model.</summary>
        private GreetingViewModel _VModel;



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // private members                                                                                          //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Creates a new instanec of this class.</summary>
        /// <param name="vmodel">View model.</param>
        public GreetingCommand(GreetingViewModel vmodel)
        {
            _VModel = vmodel;
            _VModel.PropertyChanged += _VModel_PropertyChanged;
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // event handlers                                                                                           //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void _VModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(GreetingViewModel.Name)) 
            { 
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // [interface] ICommand                                                                                     //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Raised when the CamExecute() result has changed.</summary>
        public event EventHandler? CanExecuteChanged;


        /// <summary>Gets if the command can be executed.</summary>
        /// <param name="parameter">Parameter.</param>
        /// <returns>Returns TRUE if the command can be executed, otherwise returns FALSE.</returns>
        public bool CanExecute(object? parameter)
        {
            return (!string.IsNullOrWhiteSpace(_VModel.Name));
        }


        /// <summary>Executes the command.</summary>
        /// <param name="parameter">Parameter.</param>
        public void Execute(object? parameter)
        {
            if(!CanExecute(parameter)) return;

            _VModel.GreetingText = $"Hello {_VModel.Name}!";
        }
    }
}
