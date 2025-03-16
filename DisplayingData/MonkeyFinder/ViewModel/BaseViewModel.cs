namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
  public BaseViewModel()
  {
  }
  
  [ObservableProperty]
  [NotifyPropertyChangedFor(nameof(IsNotBusy))]
  // [AlsoNotifyChangeFor] ---> [NotifyPropertyChangedFor] -- UPDATE FROM OLD DOCS 
  bool isBusy;
  
  [ObservableProperty]
  string title;
  
  public bool IsNotBusy => !IsBusy;


  // public bool IsBusy
  // {
  //   get => isBusy;
  //   set
  //   {
  //     if (isBusy == value)
  //       return;

  //     isBusy = value;
  //     // OnPropertyChanged("IsBusy");
  //     // OnPropertyChanged(nameof(IsBusy));
  //     OnPropertyChanged();
  //     OnPropertyChanged(nameof(IsNotBusy));
  //   }
  // }

  // public string Title{
  //   get => title;
  //   set
  //   {
  //     if (title == value){
  //       return;
  //     }
  //     title= value;
  //     OnPropertyChanged();
  //   }
  // }

  // public bool IsNotBusy => !IsBusy;

  // public event PropertyChangedEventHandler PropertyChanged;

  // public void OnPropertyChanged([CallerMemberName] string name = null)
  // {
  //   PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
  // }
}
