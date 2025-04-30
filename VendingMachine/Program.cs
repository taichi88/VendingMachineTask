// See https://aka.ms/new-console-template for more information
using VendingMachine;

Console.WriteLine("Hello, World!");

MachineClass machine;
while (true)
try 
{
    Console.WriteLine("Hello this is Vending machine Please Enter the amount (20, 50, 100, 500) of money");
    int inputAmount = Convert.ToInt32(Console.ReadLine().Trim());

    machine = new MachineClass(inputAmount);
    machine.printMoney();
        break;
    
}
    catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

while (true)
    try
    {
        foreach (var product in Enum.GetValues<MachineClass.chosenMenu>())
            Console.WriteLine($"{(int)product}.{product}");


        Console.WriteLine("Please Choose the product you want ");
        int inputAmount = Convert.ToInt32(Console.ReadLine().Trim());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
