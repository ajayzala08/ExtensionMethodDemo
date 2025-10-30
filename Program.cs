
var laptop = new Product { Price = 3000, ProductName = "Laptop" };

Console.WriteLine( laptop.IsProductExpensive());


//Console.WriteLine($"Formated Date : {DateTime.Now.FormateDate()}");


/*int num1 = 23;
int num2 = 28;

Console.WriteLine($"{num1.IsOddOrEven()} and {num2.IsOddOrEven()}");*/



//first create static class and create static method 

//now lets call this method

//string str = "My example of extension method!";

//we can use extension method like instance method
//now lets run and check
//Console.WriteLine(str.AddPrefix("Hello"));

//we can use like chain method 

//Console.WriteLine(str.AddPrefix("Hello").AddSuffix("Check this."));


public static class StringExtension
{
    public static string AddPrefix(this string value, string prefix)
    { 
        return  prefix +" " + value;
    }


    //we add another method
    public static string AddSuffix(this string value, string suffix)
    {
        return value +" " +suffix;
    }
}


public static class intExtension
{
    public static string IsOddOrEven(this int value)
    {
        return value % 2 == 0 ? $" {value} is Even" : $"{value} is Odd";
    }
}

public static class DateExtension
{
    public static string FormateDate(this DateTime date)
    {
        return date.ToString("dd-MMM-yyyy HH:mm");
    }
}

//Same way you can use decimal method extensino now will see class extension method


public class Product 
{
    public int Price { get; set; }
    public string ProductName { get; set; }
}

//Now lets extened this class

public static class ProductExtension
{
    public static string IsProductExpensive(this Product product)
    {
        if (product.Price > 10000)
        {
            return "Product is expensive!";
        }
        else {
            return "Product is not expensive!";
        }

    }
}