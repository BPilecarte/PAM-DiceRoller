using System.Diagnostics.Metrics;

namespace DiceRoller;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
    }

	private void btnRandom_Click(object sender, EventArgs e)
	{
		Random numAleatorio = new Random();

		string Resultado = "";

		for (int i = 0; i <= 1 -1; i++)
		{
			Resultado += numAleatorio.Next(1,5);
			dicerNumber.Text = Resultado;

        }
    }
}

