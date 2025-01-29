namespace machineCoffe
{
    public partial class Form1 : Form
    {
        private CoffeeMachine coffeeMachine;

        public Form1()
        {
            InitializeComponent();
            coffeeMachine = new CoffeeMachine();
            coffeeMachine.OnIngredientsChanged += UpdateIngredientLabels;
            UpdateIngredientLabels();
        }
        private void UpdateIngredientLabels()
        {
            Dictionary<string, int> ingredients = coffeeMachine.GetIngredients();
            lblWater.Text = $"Water: {ingredients["water"]} g";
            lblCoffee.Text = $"Coffee: {ingredients["coffee"]} g";
            lblChocolate.Text = $"Chocolate: {ingredients["chocolate"]} g";
            lblMilk.Text = $"Milk: {ingredients["milk"]} g";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBlackCoffee_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("BlackCoffee");
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("Mocha");
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("Latte");
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("Chocolate");
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            coffeeMachine.RefillIngredients();
        }
    }
}
