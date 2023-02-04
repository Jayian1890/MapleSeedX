namespace MapleSeedX.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Username = string.Empty;
        Userpass = string.Empty;
    }

    public string Greeting => "Welcome to MapleSeed X";
    
    public string Username { get; set; }
    
    public string Userpass { get; set; }
    
    public bool Autologin { get; set; }
}