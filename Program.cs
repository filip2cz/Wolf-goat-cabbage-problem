bool working = true;
bool prevoznik = false;
bool vlk = false;
bool koza = false;
bool zeli = false;
int choice;
int pokusy = 0;
while (working)
{
    Thread.Sleep(5);
    choice = new Random().Next(0, 3);
    pokusy++;
    //Console.WriteLine(choice);
    
    prevoznik = !prevoznik;
    
    if (choice == 0)
    {
        if (vlk == koza == !prevoznik)
        {
            vlk = !vlk;
        }
        else if (koza == zeli == !prevoznik)
        {
            vlk = !vlk;
        }
        else
        {
            Console.WriteLine("Převozník přejel sám");
        }
    }
    else if (choice == 1)
    {
        vlk = !vlk;
        if (vlk == koza == !prevoznik)
        {
            vlk = !vlk;
        }
        else if (koza == zeli == !prevoznik)
        {
            vlk = !vlk;
        }
        else
        {
            Console.WriteLine("Vlk převezen");
        }
    }
    else if (choice == 2)
    {
        koza = !koza;
        if (vlk == koza == !prevoznik)
        {
            vlk = !vlk;
        }
        else if (koza == zeli == !prevoznik)
        {
            vlk = !vlk;
        }
        else
        {
            Console.WriteLine("Koza převezena");
        }
    }
    else if (choice == 3)
    {
        zeli = !zeli;
        if (vlk == koza == !prevoznik)
        {
            vlk = !vlk;
        }
        else if (koza == zeli == !prevoznik)
        {
            vlk = !vlk;
        }
        else
        {
            Console.WriteLine("Zelí převezeno");
        }
    }

    if (vlk == true && koza == true && zeli == true)
    {
        Console.WriteLine("Vše je na druhé straně");
        Console.Write("Počet pokusů: ");
        Console.WriteLine(pokusy);
        working = false;
    }
}