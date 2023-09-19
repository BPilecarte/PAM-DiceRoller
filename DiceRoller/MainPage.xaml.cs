using System.Diagnostics.Metrics;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		sidesPicker.SelectedIndex = 0;
	}

	public class Dice
	{
		//numSides - atributo da classe
		private int numSides;

		//construtor
		public Dice() { }

		//construtor com parametro
		public Dice(int numSides)
		{
			this.numSides = numSides;
		}

		//metodo da classe
		public int RollDice()
		{
			int radom = new Random().Next(1, numSides + 1);
			return radom;
			//ou
			//Random random = new Random();
			//int numAleatorio = random.Next(1, numSides + 1);
			//return numAleatorio
			//ou
			//return new Random().Next(1, numSides +1);
		}
	}

	public void OnChangedOption(object sender, EventArgs e)
	{
		int numSide = (int)sidesPicker.SelectedItem;
        Image image = new Image { Source = $"dice_{numSide}.png" };
		DiceImage.Source = image.Source;
	}

	public void btnRandom_Click(object sender, EventArgs e)
	{
		//ler o numero que foi selecionado no picker. Criação da variável selectedSidesNumber
		int selectedSidesNumber = (int)sidesPicker.SelectedItem;

		//chamar o metodo da classe dados(Dice) para sortear o número
		Dice dice = new Dice(selectedSidesNumber);

		//chamar o método para rodar o dado
		int NumSorteado = dice.RollDice();

		//mostrar o número sorteado na Label.   .Text irá mudar o texto(o retorno) da Label
		NumberOfDice.Text = NumSorteado.ToString();
	}

}

