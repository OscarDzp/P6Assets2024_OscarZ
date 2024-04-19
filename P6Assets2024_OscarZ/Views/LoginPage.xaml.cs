namespace P6Assets2024_OscarZ.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void SwVerPassword_Toggled(object sender, ToggledEventArgs e)
    {
		if (SwVerPassword.IsToggled)
		{
			TxtPassword.IsPassword = false;
		}
		else
		{
			TxtPassword.IsPassword = true;
		}
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    private async void BtnSingUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserSignUpPage());
    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        //TODO: Agregar llamada al API para consultar el usuario por
        //el correo y contra

        //si la respuesta es correcta entonces mostramos la pagina de
        // seleccion de opciones

        await Navigation.PushAsync(new OptionsPage());

    }
}