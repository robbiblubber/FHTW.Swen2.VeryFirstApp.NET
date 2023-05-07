using System.ComponentModel;
using System.Windows.Input;



namespace FHTW.Swen2.VeryFirstApp
{
    /// <summary>This class implements a greeting view model.</summary>
    public class GreetingViewModel: INotifyPropertyChanged
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // private members                                                                                          //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Greeting text.</summary>
        private string _GreetingText = "Hello World!";



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // constructors                                                                                             //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Creates a new instance of this class.</summary>
        public GreetingViewModel() 
        { 
            GreetingExecutionCommand = new GreetingCommand(this);
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public properties                                                                                        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Gets a command that updates the greeting.</summary>
        public ICommand GreetingExecutionCommand
        {
            get; private set;
        }


        /// <summary>Gets the name.</summary>
        public string Name
        {
            get { return GreetedEntity.Instance.Name; }
            set
            {
                if(GreetedEntity.Instance.Name != value) 
                {
                    GreetedEntity.Instance.Name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GreetingText)));
                }
            }
        }


        /// <summary>Gets or sets the greeting text.</summary>
        public string GreetingText
        {
            get
            {
                return _GreetingText;
            }
            set
            {
                _GreetingText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GreetingText)));
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // [interface] INotifyPropertyChanged                                                                       //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>Raised when a property is changed.</summary>
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}