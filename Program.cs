using Task190423.Models;


Shop shop = new Shop();
Shop shop2 = new Shop();

Product egg = new Product("Vlack shirt n", "Ucuz yumurta", true, 0.20);
Product bread = new Product("Corek", "Nur zavodu", true, 0.50);
Product juice = new Product("Sok", "Cappy", false, 1.50);
Product kartof = new Product("dvxvb", "kartoshkaaaaa", true, 1);

shop.AddProduct(egg);
shop.AddProduct(bread);
shop.AddProduct(juice);

shop2.AddProduct(kartof);
/*Console.WriteLine("gvfdjkgbvdkjfbgdbv" + shop2.GetProduct(kartof.Title)); 

Console.WriteLine(shop.GetProduct(2));

Console.WriteLine(shop.GetProduct("Yumurta"));

Console.WriteLine(shop.GetProduct(0.50, 1.60));*/

Console.WriteLine(egg.Code);

/*foreach (var item in shop.GetInStockProducts())
{
    Console.WriteLine(item);
}*/