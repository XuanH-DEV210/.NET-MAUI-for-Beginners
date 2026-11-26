using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace MAUI_for_Beginners.ViewModel
{

    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity)
        {

            this.connectivity = connectivity;
            items = new ObservableCollection<string>();
        }
        public MainViewModel()
        {
            items = new ObservableCollection<string>();
        }
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh Oh", "No Internet", "OK");
                return;
            }

            items.Add(text);
            text = string.Empty;
        }
        void Delete(string s)
        {
            if (items.Contains(s))
                items.Remove(s);
        }
    
    async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?id={s}");
         
        }
    }
}
        
    