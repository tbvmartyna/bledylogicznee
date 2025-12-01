/* Obliczanie obwodu prostokąta 

Kod oblicza obwód prostokąta. Gdzie jest błąd? 


int dlugosc = 10;

int szerokosc = 5;

int obwod = dlugosc + szerokosc;

Console.WriteLine($"Obwód: {obwod}");*/

using System.Collections.Generic;

Console.WriteLine("Zadanie 1");
int dlugosc = 10;

int szerokosc = 5;

int obwod = 2*dlugosc + 2*szerokosc; /* bląd polegal na liczeniu 
                                      * tylko dwoch bokow zamiast wszystkich*/

Console.WriteLine($"Obwód: {obwod}");

Console.WriteLine("Zadanie 2");

/*Zliczanie samogłosek 
Program ma zliczyć samogłoski w słowie. Co jest źle? 

string slowo = "programowanie";
int licznik = 0;
foreach (char litera in slowo)

{

    if (litera == 'a' || litera == 'e' || litera == 'i' ||

      litera == 'o' || litera == 'u')

    {

        licznik++;

    }

}



Console.WriteLine($"Liczba samogłosek: {licznik}");*/
string slowo = "programowanie";
int licznik = 0;
foreach (char litera in slowo)

{

    if (litera == 'a' || litera == 'e' || litera == 'i' ||

      litera == 'o' || litera == 'u')

    {

        licznik++;

    }

}
Console.WriteLine($"Liczba samogłosek: {licznik}");/* brak bledu*/

Console.WriteLine("Zadanie 3");

/*
Sprawdzanie liczby dodatniej 
Kod sprawdza, czy liczba jest dodatnia. Znajdź błąd. 

int liczba = 0;
if (liczba > 0)
{
    Console.WriteLine("Liczba dodatnia");
}

else
{
    Console.WriteLine("Liczba ujemna");
}
 */

int liczba = 0;
if (liczba > 0)
{
    Console.WriteLine("Liczba dodatnia");
}

else if (liczba < 0)
{
    Console.WriteLine("Liczba ujemna");/* bledem jest to, ze zero zostalo potraktowane
                                        * jako liczba ujemna, wystarczylo dodac jeszcze jednego ifa i else
                                        * w razie gdy liczba jest zerem*/
}
else
{
    Console.WriteLine("Podana liczba wynosi 0");
}
Console.WriteLine("Zadanie 4");
/*Obliczanie VAT 
Program dodaje VAT do ceny netto. Gdzie błąd? 

double cenaNetto = 100;

double vat = 23; // 23% 

double cenaBrutto = cenaNetto + vat;

Console.WriteLine($"Cena brutto: {cenaBrutto}");*/


double cenaNetto = 100;
double vat = 23; /*blad to //23%, wystarczylo to usunac*/
double cenaBrutto = cenaNetto + vat;

Console.WriteLine($"Cena brutto: {cenaBrutto}");


Console.WriteLine("Zadanie 5");

/*Sprawdzanie roku przestępnego 
Kod ma sprawdzać, czy rok jest przestępny. Co jest nie tak? 

int rok = 2024;
if (rok % 4 == 0)

{
    Console.WriteLine("Rok przestępny");
}

else

{
    Console.WriteLine("Rok nieprzestępny");
}*/

int rok = 2024;
if (rok % 4 != 0)
{ 
   Console.WriteLine("Rok nieprzestępny");
}

else if (rok % 4 == 0)

{
    Console.WriteLine("Rok przestępny");
};


Console.WriteLine("Zadanie 10");
/*
Obliczanie dnia tygodnia 
Kod oblicza dzień tygodnia dla daty. Gdzie błąd? 


int dzien = 15, miesiac = 11, rok = 2024;

DateTime data = new DateTime(rok, miesiac, dzien);

string dzienTygodnia = data.DayOfWeek.ToString();

Console.WriteLine($"Dzień tygodnia: {dzienTygodnia}");*/



int dzien = 15;
int miesiac = 11;
int rokk = 2024;

DateTime data = new DateTime(rokk, miesiac, dzien);

string dzienTygodnia = data.DayOfWeek.ToString();

Console.WriteLine($"Dzień tygodnia: {dzienTygodnia}");/*brak bledu*/




