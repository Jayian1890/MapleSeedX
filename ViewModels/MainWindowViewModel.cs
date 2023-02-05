using System.Windows.Input;
using ReactiveUI;

namespace MapleSeedX.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        OnDecryptCommand = ReactiveCommand.Create(() => OnDecryptClick());
    }

    public ICommand OnDecryptCommand { get; }

    private string _encryptedFilePath = string.Empty;

    public string EncryptedFilePath 
    {
        get => _encryptedFilePath;
        set => this.RaiseAndSetIfChanged(ref _encryptedFilePath, value);
    } 

    private bool _isProgressBusy = false;

    public bool IsProgressBusy 
    {
        get => _isProgressBusy;
        set => this.RaiseAndSetIfChanged(ref _isProgressBusy, value);
    }

    public void OnDecryptClick()
    {
        ProgressText = "Starting decryption...";
        IsProgressBusy = true;
    }

    private string _progressText = string.Empty;

    public string ProgressText
    {
        get => _progressText;
        set => this.RaiseAndSetIfChanged(ref _progressText, value);
    }
}