using hf0222;

string szo1 = "ElsőSzó";
string szo2 = "MásodikSzó";
SzovegOsszefuzo osszefuzo = new SzovegOsszefuzo(szo1, szo2);
string eredmeny = osszefuzo.SzoOsszefuzo();
Console.WriteLine(eredmeny);

Console.ReadKey();