// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

int bodzio = 280000;
long price=0;

Console.WriteLine("Hello, World!");

Fms fms = new Fms();
int i = 0;
Random f;
while (i<1000000)
{
    fms.enhance();
    if(fms.enchant == 9)
    {
        fms.enchant = 0;
        i++;
    }
    
}

Console.WriteLine("price per fms is equal to " + (fms.price / 1000000));