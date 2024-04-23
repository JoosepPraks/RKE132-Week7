// < 10 - 1%
//total >= 10 && 20 total <20
// taotal >= 20 - 10%

Console.WriteLine("Provide total");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}