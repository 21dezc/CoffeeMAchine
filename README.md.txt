#Coffee Machine Program 

by irada prorasri,
673450206-5,
Computer and Infomation Science, KKU

![Coffee Machine]()

## Updating the inventory and the number of times the drink order is pressed
```
private void UpdateIngredientLabels()
{
    Dictionary<string, int> ingredients = coffeeMachine.GetIngredients();
    lblWater.Text = $"Water: {ingredients["water"]} g";
    lblCoffee.Text = $"Coffee: {ingredients["coffee"]} g";
    lblChocolate.Text = $"Chocolate: {ingredients["chocolate"]} g";
    lblMilk.Text = $"Milk: {ingredients["milk"]} g";

    lblBlackCoffeeCount.Text = $"Black Coffee: {drinkCount["BlackCoffee"]} ครั้ง";
    lblMochaCount.Text = $"Mocha: {drinkCount["Mocha"]} ครั้ง";
    lblLatteCount.Text = $"Latte: {drinkCount["Latte"]} ครั้ง";
    lblChocolateCount.Text = $"Chocolate: {drinkCount["Chocolate"]} ครั้ง";
}
```

##  Drink ordering process
```
private void btnBlackCoffee_Click(object sender, EventArgs e)
{
    coffeeMachine.MakeDrink("BlackCoffee");
    drinkCount["BlackCoffee"]++;
    UpdateIngredientLabels();
}
```

##  Replenishing the ingredients
```
private void btnRefill_Click(object sender, EventArgs e)
{
    coffeeMachine.RefillIngredients();
    drinkCount["BlackCoffee"] = 0;
    drinkCount["Mocha"] = 0;
    drinkCount["Latte"] = 0;
    drinkCount["Chocolate"] = 0;
    UpdateIngredientLabels();
}
```

 ## Class Diagram
 ```
 ---CoffeeMachine---
 - ingredients   
 - recipes       
 - OnIngredientsChanged
 +GetIngredients()  
 + MakeDrink()       
 + RefillIngredients()
  ---Form1---
- coffeeMachine: CoffeeMachine 
- drinkCount: Dictionary
+ UpdateIngredientLabels()  
+ btnBlackCoffee_Click()    
+ btnMocha_Click()          
+ btnLatte_Click()          
+ btnChocolate_Click()      
+ btnRefill_Click()    
```
