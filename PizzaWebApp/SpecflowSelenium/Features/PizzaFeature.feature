Feature: PizzaShop
			Ordering pizza
@mytag
Scenario: Pizza order 
	Given I navigate to PizzaShop page
	Then I click on all pizza button and add pizza to the cart
	Then I click on veg pizza button and add veg pizza to the cart
	Then I click on non veg pizza and add non veg pizza to the cart
	Then I click on view cart button to check the order list
	Then add or remove pizzas
	When I click Checkout button order should be placed