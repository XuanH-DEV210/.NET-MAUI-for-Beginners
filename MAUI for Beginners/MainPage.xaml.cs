using MAUI_for_Beginners.ViewModel;

namespace MAUI_for_Beginners
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

 
    }
}
