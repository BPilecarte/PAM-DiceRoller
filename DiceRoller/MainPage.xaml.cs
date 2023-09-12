using System.Diagnostics.Metrics;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    int numSides = 6;

    public MainPage()
	{
		InitializeComponent();
		sidesPicker.SelectedIndex = 0;
    }

	public class Dice
	{
		//public int QuantidadeDeLados { get; set; }

		public Dice() { }

		public Dice(int numSides)
		{
			this.numSides = numSides;
		}

		private int numSides;

		public int RollDice()
		{
			int radom = new Random().Next(1, numSides +1);
			return radom;
		}
	}

	public void btnRandom_Click(object sender, EventArgs e)
	{
		numSides = Convert.ToInt32(sidesPicker.SelectedItem.ToString());
		Dice dice = new Dice(); //os numéros do picker deve ficar dentro do ()
        NumberOfDice.Text = dice.RollDice().ToString();


    }










	//private void btnRandom_Click(object sender, EventArgs e)
	//{
		//var maxValue = sidesPicker.SelectedItem; 
		
		//var numeroSorteado = new Random().Next(1, (int)maxValue);

		//DiceOfNumber. Text = numeroSorteado.ToString();
    //}





}

