namespace Ejemplo021925597;

public partial class Ejemplo2 : ContentPage
{
	/// <summary>
	/// Inicializa la p�gina
	/// </summary>
	public Ejemplo2()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Retorna el texto en el bot�n al iniciar este evento
	/// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
		(sender as Button).Text = "Presioname de nuevo";
    }
}