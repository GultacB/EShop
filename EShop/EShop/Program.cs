
using EShop.EShopModel;
using System.Collections.Concurrent;
using System.Security;
while (true) {
List<Product> ProductList=new List<Product>() 
{
new Product(){ProductName="Pizza",ProductKindOf1= "ITALIANO-Medium",ProductKindOf1Amount= 20.40, ProductKindOf2="KENTUCKY BBQ STEAK-Small", ProductKindOf2Amount=12.40, ProductKindOf3="EXTRAVAGANZA-Large",ProductKindOf3Amount= 27.30 },
new Product(){ProductName="Bread",ProductKindOf1= "CHEESY GARLIC BREAD",ProductKindOf1Amount= 6.90,ProductKindOf2= "CHEESE BITE",ProductKindOf2Amount= 2.50,ProductKindOf3= "MANGAL SUCUK SANDWICH",ProductKindOf3Amount= 5.20 },
new Product(){ProductName="Salad",ProductKindOf1= "TUNA SALAD",ProductKindOf1Amount= 4.90,ProductKindOf2= "FETA CHEESE SALAD",ProductKindOf2Amount= 4.90,ProductKindOf3= "CHICKEN SALAD",ProductKindOf3Amount= 4.90},
new Product(){ProductName="Drinks",ProductKindOf1= "COCA-COLA ZERO-500ml",ProductKindOf1Amount= 2.50,ProductKindOf2= "FANTA-330ml",ProductKindOf2Amount= 3, ProductKindOf3="FUSE TEA-peach",ProductKindOf3Amount= 3 },
} ;
    Dictionary<string, double> ProductAmount = new Dictionary<string, double>();
    ProductAmount.Add("ITALIANO-Medium", 20.40);
    ProductAmount.Add("KENTUCKY BBQ STEAK-Small", 12.40);
    ProductAmount.Add("EXTRAVAGANZA-Large", 27.30);
    ProductAmount.Add("CHEESY GARLIC BREAD", 6.90);
    ProductAmount.Add("CHEESE BITE", 2.50);
    ProductAmount.Add("MANGAL SUCUK SANDWICH", 5.20);
    ProductAmount.Add("TUNA SALAD", 4.90);
    ProductAmount.Add("FETA CHEESE SALAD", 4.90);
    ProductAmount.Add("CHICKEN SALAD", 4.90);
    ProductAmount.Add("COCA-COLA ZERO-500ml", 2.50);
    ProductAmount.Add("FANTA-330ml", 3);
    ProductAmount.Add("FUSE TEA-peach", 3);
   

    Console.Write("Are you User or Admin?:"); string answer = Console.ReadLine().ToLower();
    switch (answer)
    {
        case "user":
            Console.Write("Register\nEnter your Name:"); string UserName = Console.ReadLine().ToUpper();
            Console.Write("Enter your Surname:"); string UserSurname = Console.ReadLine().ToUpper();
            Console.Write("Enter your Address:"); string UserAddress = Console.ReadLine().ToUpper();
            Console.Write("Enter your Phone's number:"); double UserPhoneNumber = double.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("                          Login                             ");
            Console.WriteLine("1.for to see Product's Categories\n2.for to add to cart and for to see orders list in cart\n3.for to see total price\n4.for to remove order in cart");
            Console.Write("Enter number of your choice:"); int ChoiceNumber = int.Parse(Console.ReadLine());
            switch (ChoiceNumber)
            {
                case 1:
                    Console.Clear();
                    foreach (var product in ProductList)
                    {
                        Console.WriteLine($"{product.ProductName}==>{product.ProductKindOf1}'s amount {product.ProductKindOf1Amount}azn, {product.ProductKindOf2}'s amount {product.ProductKindOf2Amount}azn, {product.ProductKindOf3}'s amount {product.ProductKindOf3Amount}azn");
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Enter your choice product:"); 
                    var selectedProduct = Console.ReadLine().ToUpper();
                    List<Cart> OrderList = new List<Cart>()
                    {new Cart() { SelectedProduct = selectedProduct }};
                    if(OrderList.Count > 0) { 
                    foreach (var item in OrderList)
                    {
                        Console.WriteLine(item.SelectedProduct);
                    }
                    }
                    else
                    {
                        Console.WriteLine("Cart is empty");
                    }
                    break; 
                case 3:
                    Console.Clear();
                    Console.Write("Enter your choice product for to know amount:");
                    string forKnowAmount = Console.ReadLine().ToUpper();
                    DayOfWeek wk = DateTime.Today.DayOfWeek;
                    if (wk == DayOfWeek.Sunday)
                    {
                        Console.WriteLine($"Your choice product's amount is {ProductAmount[forKnowAmount] - (ProductAmount[forKnowAmount] * 20) / 100} AZN");
                    }
                    else
                    {
                        Console.WriteLine($"Your choice product's amount is {ProductAmount[forKnowAmount]} AZN");
                    }
                    break;
                case 4:
                    break;    
            }
            Console.ReadKey();
            Console.Clear();
         break;

        case "admin":
            List<User> UserStatus = new List<User>()
            { new User() { Name =UserName},
              new User() { Surname =UserSurname},
              new User(){ Address =UserAddress},
              new User() { PhoneNumber = UserPhoneNumber }
            };





            break;


    }
}







