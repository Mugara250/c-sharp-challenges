using c_sharp_challenges;

ShoppingCart cart = new ShoppingCart();
Console.WriteLine(cart.GetItemCount());
Console.WriteLine(cart.GetTotal());

cart.AddItem(200m);
Console.WriteLine(cart.GetItemCount());
Console.WriteLine(cart.GetTotal());

//cart.AddItem(-203m);

cart.AddItem(300m);
cart.AddItem(234m);

Console.WriteLine(cart.GetItemCount());
Console.WriteLine(cart.GetTotal());
