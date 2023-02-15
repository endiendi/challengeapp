string strName = "Ewa";
int intAge = 33;
bool bolWoman = true;



if (bolWoman == true)
{
    if (intAge < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        if (strName == "Ewa" && intAge == 33)
        {
            Console.WriteLine("Ewa, lat 33");
        }
        else
            Console.WriteLine("Kobieta w wieku " + intAge);
    }
}
else
{
    if (intAge < 18)
    {
        Console.WriteLine("Niepełnoletni męszczyzna");
    }
    else
    {
        Console.WriteLine("Męszczyzna w wieku " + intAge);
    }
}


