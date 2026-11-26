using MAUI_for_Beginners.ViewModel;

namespace MAUI_for_Beginners;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}