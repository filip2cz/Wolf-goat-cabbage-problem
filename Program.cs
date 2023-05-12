bool working = true;
bool prevoznik = false;
bool vlk = false;
bool koza = false;
bool zeli = false;
int choice;
while (working)
{
    choice = new Random().Next(0, 3);

    if (choice == 0)
    {
        vlk = !vlk;
        if (vlk == koza)
        {
            Console.WriteLine("Koza umřela, jdeme o krok zpět");
        }
        else if (koza == zeli)
        {
            Console.WriteLine("Zelí umřelo, jdeme o krok zpět");
        }
        else
        {

        }
    }
    if (choice == 1)
    {
        if (vlk == koza)
        {
            Console.WriteLine("Koza umřela, jdeme o krok zpět");
        }
        else if (koza == zeli)
        {
            Console.WriteLine("Zelí umřelo, jdeme o krok zpět");
        }
    }
    if (choice == 2)
    {
        if (vlk == koza)
        {
            Console.WriteLine("Koza umřela, jdeme o krok zpět");
        }
        if (koza == zeli)
        {
            Console.WriteLine("Zelí umřelo, jdeme o krok zpět");
        }
    }
    if (choice == 3)
    {
        if (vlk == koza)
        {
            Console.WriteLine("Koza umřela, jdeme o krok zpět");
        }
        if (koza == zeli)
        {
            Console.WriteLine("Zelí umřelo, jdeme o krok zpět");
        }
    }
}