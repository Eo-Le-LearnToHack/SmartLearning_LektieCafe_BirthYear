// See https://aka.ms/new-console-template for more information

using CPR;

Personoplysning person1 = new();

person1.CPR_met(uint first6digits, uint last4digits); //Indtast dit CPRnr her. Kør programmet og den udregner dit fødselsår.
Console.WriteLine(person1.Udskriv_fødselsår_met());
