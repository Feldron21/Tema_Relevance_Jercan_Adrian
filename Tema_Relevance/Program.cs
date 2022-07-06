using Tema_Relevance.Clase;

string nr, gr, vl;
//Afisarea meniului pentru a introduce limitele de initializare ale ghiozdanului
Console.WriteLine("Introduceti limitele ghiozdanului:\nNumar maxim de obiecte:");
nr = Console.ReadLine();
Console.WriteLine("Greutate maxima:");
gr = Console.ReadLine();
Console.WriteLine("Volum Maxim:");
vl = Console.ReadLine();

//crearea obiectului de tip ghiozdan cu valorile introduse anterior
Ghiozdan ghiozdan = new Ghiozdan(int.Parse(nr),float.Parse(gr),float.Parse(vl));

while (true)
{
    //Afisarea meniului cu articolele
    Console.WriteLine("Tastati ce obiect doriti sa introduceti in ghiozdan:\n\n   1.Sageata\n      Greutate: 0.1\n      Volum: 0.05\n   2.Arc\n      Greutate: 1\n      Volum: 4\n   3.Franghie\n      Greutate: 1\n      Volum: 1.5\n   4.Apa\n      Greutate: 2\n      Volum: 3\n   5.Portie de mancare\n      Greutate: 1\n      Volum: 0.5\n   6.Sabie\n      Greutate: 5\n      Volum: 3\n\nTastati numele obiectului:");

    //Citirea articolului ce se doreste a fi introdus in ghiozdan
    string userInput = "";
    userInput = Console.ReadLine();

    //Folosim un switch cu cazuri pentru fiecare articol si adaugam articolul daca se respecta limitele ghiozdanului
    switch (userInput.ToLower())
    {
        case "sageata":
            Sageata sageata = new Sageata();
            Console.WriteLine($"\nAdaugarea a fost facuta: {ghiozdan.Adauga(sageata)}");
            break;

        case "arc":
            Arc arc = new Arc();
            Console.WriteLine($"\nAdaugarea a fost facuta: {ghiozdan.Adauga(arc)}");
            break;

        case "franghie":
            Franghie franghie = new Franghie();
            Console.WriteLine($"\nAdaugarea a fost facuta: {ghiozdan.Adauga(franghie)}");
            break;

        case "apa":
            Apa apa = new Apa();
            Console.WriteLine($"\nAdaugarea a fost facuta: {ghiozdan.Adauga(apa)}");
            break;

        case "portie de mancare":
            PortieMancare portie = new PortieMancare();
            Console.WriteLine($"\nAdaugarea a fost facuta: {ghiozdan.Adauga(portie)}");
            break;

        case "sabie":
            Sabie sabie = new Sabie();
            Console.WriteLine($"\nAdaugarea a fost facuta: {ghiozdan.Adauga(sabie)}");
            break;


    }

    //Afisam dupa fiecare adaugare sau incercare de adaugare parametrii articolului
    ghiozdan.AfisareParametriiArticole();
}
