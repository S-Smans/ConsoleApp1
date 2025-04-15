//// 5 tema

//var persona = new Persona();
//persona.Registret();
//persona.Izvadit();

//public class Prece
//{
//    public string tips;
//    public double cena;

//    public void Registret()
//    {
//        Console.WriteLine("Ievadi tipu");
//        tips = Console.ReadLine();

//        Console.WriteLine("Ievadi cenu");
//        cena = Convert.ToDouble(Console.ReadLine());
//    }

//    public void Izvadit()
//    {
//        Console.WriteLine($"Preces nosaukums: {tips}");
//        Console.WriteLine($"Preces cena: {cena:F2} EUR");
//    }
//}

//public class Grozs
//{
//    public int skaits { get; set; }
//    public Prece[] preces { get; set; }

//    public void Registret()
//    {
//        Console.Write("Ievadiet precu skaitu groza: ");
//        skaits = Convert.ToInt32(Console.ReadLine());
//        preces = new Prece[skaits];

//        for (int i = 0; i < skaits; i++)
//        {
//            Console.WriteLine($"Ievadiet informaciju par {i + 1}. preci:");
//            preces[i] = new Prece();
//            preces[i].Registret();
//        }
//    }

//    public double Kopsuma()
//    {
//        double kopsumma = 0;
//        foreach (var prece in preces)
//        {
//            kopsumma += prece.cena;
//        }
//        return kopsumma;
//    }

//    public void Izvadit()
//    {
//        Console.WriteLine($"Precu skaits groza: {skaits}");
//        foreach (var prece in preces)
//        {
//            prece.Izvadit();
//        }
//        Console.WriteLine($"Precu kopeja summa: {Kopsuma()}");
//    }
//}

//public class Persona
//{
//    public string vards { get; set; }
//    private string parole;
//    public Grozs grozs { get; set; }
//    public double lidzekli { get; set; }

//    public void Registret()
//    {
//        Console.Write("Ievadiet vārdu: ");
//        vards = Console.ReadLine();

//        Console.Write("Ievadiet paroli: ");
//        parole = Console.ReadLine();

//        grozs = new Grozs();
//        grozs.Registret();

//        Console.Write("Ievadiet pieejamos līdzekļus: ");
//        lidzekli = Convert.ToDouble(Console.ReadLine());
//    }

//    public bool PietiekLidzeklu()
//    {
//        return lidzekli >= grozs.Kopsuma();
//    }

//    public void Izvadit()
//    {
//        Console.WriteLine($"Vards: {vards}");
//        Console.WriteLine($"Pieejamie lidzekli: {lidzekli:F2} EUR");
//        grozs.Izvadit();
//        Console.WriteLine($"Pietiek lidzeklu: {PietiekLidzeklu()}");
//    }
//}

//// 6 tema

//Console.Write("Ievadiet liniju skaitu: ");
//int linijuSkaits = int.Parse(Console.ReadLine());

//Linija[] linijas = new Linija[linijuSkaits];

//for (int i = 0; i < linijuSkaits; i++)
//{
//    Console.WriteLine($"\nRegistrejam liniju {i + 1}:");
//    linijas[i] = new Linija();
//    linijas[i].Registret();
//}

//Console.WriteLine("\nIzvadam linijas informaciju:");
//foreach (var linija in linijas)
//{
//    linija.Izvadit();
//}

//public class Punkts
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public string Krasa { get; set; }

//    public void Registret()
//    {
//        Console.Write("Ievadiet X koordinātu: ");
//        X = int.Parse(Console.ReadLine());

//        Console.Write("Ievadiet Y koordinātu: ");
//        Y = int.Parse(Console.ReadLine());

//        Console.Write("Ievadiet punkta krāsu: ");
//        Krasa = Console.ReadLine();
//    }

//    public void Izvadit()
//    {
//        Console.WriteLine($"Punkts ({X}, {Y}), Krāsa: {Krasa}");
//    }
//}

//public class Linija
//{
//    public Punkts A { get; set; }
//    public Punkts B { get; set; }
//    public string Krasa { get; set; }
//    public void Registret()
//    {
//        Console.WriteLine("Registrejiet pirmo punktu (A):");
//        A = new Punkts();
//        A.Registret();

//        Console.WriteLine("Registrejiet otro punktu (B):");
//        B = new Punkts();
//        B.Registret();

//        Console.Write("Ievadiet linijas krasu: ");
//        Krasa = Console.ReadLine();
//    }

//    public double Garums()
//    {
//        int deltaX = B.X - A.X;  // Atšķirība starp X koordinātēm
//        int deltaY = B.Y - A.Y;  // Atšķirība starp Y koordinātēm

//        // Pitagora teorēma: Garums = √((X2 - X1)^2 + (Y2 - Y1)^2)
//        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
//    }

//    public void Izvadit()
//    {
//        Console.WriteLine("Līnija:");
//        Console.Write("Punkts A: ");
//        A.Izvadit();
//        Console.Write("Punkts B: ");
//        B.Izvadit();
//        Console.WriteLine($"Līnijas krāsa: {Krasa}");
//        Console.WriteLine($"Linijas garums: {Garums()}");
//    }
//}


// 7 tema



static Klase MekletKlasi(List<Klase> klases, string nosaukumus)
{
    return klases.FirstOrDefault(k => k.Nosaukums == nosaukumus);
}

Console.Write("Ievadiet klasu skaitu: ");
int klasesSkaits = int.Parse(Console.ReadLine());
List<Klase> klases = new List<Klase>();
for (int i = 0; i < klasesSkaits; i++)
{
    Klase klase = new Klase();
    klase.Registret();
    klases.Add(klase);
}



bool turpinat = true;
while (turpinat)
{
    Console.WriteLine("Izvelne:");
    Console.WriteLine("1- Izveidot jaunas klases");
    Console.WriteLine("2- Izvadit informaciju par klasem");
    Console.WriteLine("3- Atrast konkreto klasi");
    Console.WriteLine("4- Sameklet konkreto skolenu");
    Console.WriteLine("5- Konkreta klase sameklet visvecako skolenu");
    Console.WriteLine("0- Iziet");

    int izvele = int.Parse(Console.ReadLine());
    switch (izvele)
    {
        case 1:
            Console.Write("Ievadiet klasu skaitu: ");
            klasesSkaits = int.Parse(Console.ReadLine());
            for (int i = 0; i < klasesSkaits; i++)
            {
                Klase klase = new Klase();
                klase.Registret();
                klases.Add(klase);
            }
            break;
        case 2:
            foreach (var klase in klases)
            {
                klase.Izvadit();
            }
            break;
        case 3:
            Console.Write("Ievadiet klases nosaukumu: ");
            string nosaukums = Console.ReadLine();
            Klase atrastaKlase = MekletKlasi(klases, nosaukums);
            if (atrastaKlase != null)
            {
                atrastaKlase.Izvadit();
            }
            else
            {
                Console.WriteLine("Klase netika atrasta.");
            }
            break;
        case 4:
            Console.Write("Ievadiet skolena vardu vai uzvardu: ");
            string ko_meklet = Console.ReadLine();
            Skolens atrastsSkolens = null;
            Klase atrastaSkolenaKlase = null;
            foreach (var klase in klases)
            {
                atrastsSkolens = klase.MekletSkolenu(ko_meklet);
                if (atrastsSkolens != null)
                {
                    atrastaSkolenaKlase = klase;
                    break;
                }
            }
            if (atrastsSkolens != null)
            {
                atrastsSkolens.Izvadit();
                Console.WriteLine($"Skolens atrodas klase: {atrastaSkolenaKlase.Nosaukums}");
            }
            else
            {
                Console.WriteLine("Skolens netika atrasts.");
            }
            break;
        case 5:
            Console.Write("Ievadiet klases nosaukumu: ");
            nosaukums = Console.ReadLine();
            atrastaKlase = MekletKlasi(klases, nosaukums);
            if (atrastaKlase != null)
            {
                Skolens vecakaisSkolens = atrastaKlase.VecakaisSkolens();
                if (vecakaisSkolens != null)
                {
                    vecakaisSkolens.Izvadit();
                    Console.WriteLine($"Vecakais skolens atrodas klase: {atrastaKlase.Nosaukums}");
                }
                else
                {
                    Console.WriteLine("Klase nav skolenu.");
                }
            }
            else
            {
                Console.WriteLine("Klase netika atrasta.");
            }
            break;
        case 0:
            turpinat = false;
            break;
        default:
            Console.WriteLine("Nepareiza izvele, megjiniet velreiz.");
            break;
    }
}

public class Skolens
{
    public string Vards { get; set; }
    public string Uzvards { get; set; }
    public string PersKods { get; set; }

    public void Registret()
    {
        Console.Write("Ievadiet vardu: ");
        Vards = Console.ReadLine();

        Console.Write("Ievadiet uzvardu: ");
        Uzvards = Console.ReadLine();

        Console.Write("Ievadiet personas kodu (formata DDMMYY-XXXXX): ");
        PersKods = Console.ReadLine();
    }

    public void Izvadit()
    {
        Console.WriteLine($"Vards: {Vards}");
        Console.WriteLine($"Uzvards: {Uzvards}");
        Console.WriteLine($"Personas kods: {PersKods}");
        Console.WriteLine($"Vecums: {AprekinaVecumu()} gadi");
    }

    public int AprekinaVecumu()
    {
        string dzDatumsStr = PersKods.Substring(4, 2);
        int gads = int.Parse(dzDatumsStr);
        int pilnsGads = (gads >= 0 && gads <= 23) ? 2000 + gads : 1900 + gads;
        return DateTime.Now.Year - pilnsGads;
    }
}


public class Skolotajs
{
    public string Vards { get; set; }
    public string Uzvards { get; set; }
    public double Alga { get; set; }

    public void Registret()
    {
        Console.Write("Ievadiet vardu: ");
        Vards = Console.ReadLine();

        Console.Write("Ievadiet uzvardu: ");
        Uzvards = Console.ReadLine();

        Console.Write("Ievadiet algu: ");
        Alga = double.Parse(Console.ReadLine());
    }

    public void Izvadit()
    {
        Console.WriteLine($"Vards: {Vards}");
        Console.WriteLine($"Uzvards: {Uzvards}");
        Console.WriteLine($"Alga: {Alga} EUR");
        Console.WriteLine($"Alga pec nodokliem: {AprekinaAlguPecNodokliem()} EUR");
    }

    public double AprekinaAlguPecNodokliem()
    {
        return Alga * 0.75;
    }
}

public class Klase
{
    public string Nosaukums { get; set; }
    public int SkolenuSkaits { get; set; }
    public Skolens[] Skoleni { get; set; }
    public Skolotajs KlasesAudzinatajs { get; set; }

    public void Registret()
    {
        Console.Write("Ievadiet klases nosaukumu: ");
        Nosaukums = Console.ReadLine();

        Console.Write("Ievadiet skolenu skaitu: ");
        SkolenuSkaits = int.Parse(Console.ReadLine());

        Skoleni = new Skolens[SkolenuSkaits];
        for (int i = 0; i < SkolenuSkaits; i++)
        {
            Console.WriteLine($"\nRegistrejam skolenu {i + 1}:");
            Skoleni[i] = new Skolens();
            Skoleni[i].Registret();
        }

        Console.WriteLine("\nRegistrejam klases audzinataju:");
        KlasesAudzinatajs = new Skolotajs();
        KlasesAudzinatajs.Registret();
    }

    public void Izvadit()
    {
        Console.WriteLine($"\nKlase: {Nosaukums}");
        Console.WriteLine($"Skolenu skaits: {SkolenuSkaits}");
        foreach (var skolens in Skoleni)
        {
            skolens.Izvadit();
        }

        Console.WriteLine("\nKlases audzinatajs:");
        KlasesAudzinatajs.Izvadit();
    }

    public Skolens VecakaisSkolens()
    {
        return Skoleni.OrderByDescending(s => s.AprekinaVecumu()).FirstOrDefault();
    }

    public Skolens MekletSkolenu(string ko_meklet)
    {
        return Skoleni.FirstOrDefault(s => s.Vards == ko_meklet || s.Uzvards == ko_meklet);
    }

}







