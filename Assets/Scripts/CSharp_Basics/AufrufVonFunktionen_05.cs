using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AufrufVonFunktionen_05 : MonoBehaviour
{
    // Deklaration der Funktion = Welche Funktionalität soll ausgeführt werden!
    // Aufruf der Funktion = Wann und mit welchen Werten soll die Funktionalität passieren!

    // Deklaration der Funktion
    //      - Zwei strings als Input und gibt einen gesamten string zurück
    public string AddStrings(string a, string b)
    {
        return a + b;
    }

    public string QuadraString(string x)
    {
        return x + x + x + x;
    }

    public bool IsNewNumberBigger(float numOld, float numNew)
    {
        if (numNew > numOld)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Start()
    {
        // Ich kann die Funktion AddStrings SOOFT ich möchte verwenden mit unterschiedlichen Strings!

        // Erster Aufruf der Funktion AddStrings
        //      - Die Funktion benötigt zwei string Werte zum arbeiten (siehe Deklaration)
        //      - fullName hat danach den Wert "Wilfried Gruber"
        string fullName = AddStrings("Wilfried ", "Gruber");

        // Zweiter Aufruf der Funktion AddStrings
        //      - mythicCreature hat danach den Wert "PferdAdler"
        string firstAnimal = "Pferd";
        string secondAnimal = "Adler";
        string mythicCreature = AddStrings(firstAnimal, secondAnimal);

        // Ich kann die Funktion QuadraString SOOFT ich möchte verwenden mit unterschiedlichen Strings!

        // Erster Aufruf der Funktion QuadraString
        //      - Die Funktion benötigt einen string Wert als Input (siehe Deklaration)
        //      - hi hat danach den Wert "Hallo Hallo Hallo Hallo "
        string hi = QuadraString("Hallo ");


        // Zweiter Aufruf der Funktion QuadraString
        //      - bye hat danach den Wert "See ya later! See ya later! See ya later! See ya later! "
        string bye = QuadraString("See ya later! ");

        // Ich kann die Funktion IsNewNumberBigger SOOFT ich möchte verwenden mit unterschiedlichen Strings!

        // Aufrufe der Funktion IsNewNumberBigger
        //      - Die Funktion benötigt zwei float Werte als Input (siehe Deklaration)
        bool test1 = IsNewNumberBigger(1,20);   //test1 hat danach den Wert true
        bool test2 = IsNewNumberBigger(34, 765);   //test2 hat danach den Wert true
        bool test3 = IsNewNumberBigger(576, 20);   //test3 hat danach den Wert false
        bool test4 = IsNewNumberBigger(-43, -2450);   //test4 hat danach den Wert false

    }


}
