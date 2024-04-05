namespace P6Assets2024_OscarZ.Views;

public partial class UserSignUpPage : ContentPage
{
	public UserSignUpPage()
	{
		InitializeComponent();
	}

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }
}