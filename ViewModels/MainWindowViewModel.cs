using System.Windows.Input;
using ReactiveUI;

namespace MapleSeedX.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        EncryptedFilePath = string.Empty;
        IsProgressBusy = true;
        
        OnDecryptCommand = ReactiveCommand.Create(() => OnDecryptClick());
    }

    public string Greeting => "Welcome to MapleSeed X";
    
    public string EncryptedFilePath { get; set; }
    
    public bool IsProgressBusy { get; set; }

    public ICommand OnDecryptCommand { get; }
    
    public void OnDecryptClick()
    {
        EncryptedFilePath = "Jayian";
    }
}