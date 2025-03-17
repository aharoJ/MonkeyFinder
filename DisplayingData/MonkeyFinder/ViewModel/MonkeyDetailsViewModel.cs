namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{
  public MonkeyDetailsViewModel()
  {
  }
  
  [ObservableProperty]
  Monkey monkey;

// -- THIS IS HOW WE CAN DO MODAL IN IOS 
  // [RelayCommand]
  // async Task GoBackAsync(){
  //   await Shell.Current.GoToAsync("..");
  // }
}
