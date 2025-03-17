using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    // Funktion und Methode ist der gleiche Begriff (C#)

    // 1. Deklaration einer Funktion
    // - Was genau macht die Funktion?
    // - Braucht die Funktion Input / Werte (z.b. 2 float Werte, 1 string Werte,...)
    // - Hat die Funktion ein Output und welchen Typ? ( z.b. bool, float, int, string, Vector3,...)

    // 2. Aufruf der Funktion
    // - wir verwenden die Funktionalität mit entsprechenden Werten
    //   z.b. Rotate(3,2,1); Random.Range(0f,5f);


    // Deklaration einer Funktion OHNE Input und OHNE Output
    
    // public / private       -> access modifier / Zugriffsrechte  (Wer darf die Funktion aufrufen?)
    // void / bool / string / ... -> return type  (Gibt diese Funktion ein Output zurück?) -> Bei void wird kein Wert zurückggeben
    // Spam             -> identifier ( Name der Funktion von uns selbst bestimmt)
    // ()               -> Parameterliste (Input für die Funktion)
    // {}               -> Alles was ausgeführt werden soll wenn wir die Funktion verwenden (Funktionalität)

    public void Spam()
    {
        Debug.Log("Spam!!!");
        Debug.Log("Spam!!!");
        Debug.Log("Spam!!!");
        Debug.Log("Spam!!!");
        Debug.Log("Spam!!!");
    }

    // Deklaration einer Funktion MIT Input und OHNE Output (Return Value)
    public void SpamMitInput(string myMessage)
    {
        Debug.Log(myMessage); // 57: "Wann hört endlich die Stunde auf!!!"
        Debug.Log(myMessage); // 57: "Wann hört endlich die Stunde auf!!!" 
        Debug.Log(myMessage); // 57: "Wann hört endlich die Stunde auf!!!" 
        Debug.Log(myMessage); // 57: "Wann hört endlich die Stunde auf!!!" 
        Debug.Log(myMessage); // 57: "Wann hört endlich die Stunde auf!!!" 
    }

    // Deklaration einer Funktion MIT Input und MIT OUTPUT
    // 1. Mir müssen statt void den entsprechenden Typ angeben (z.b. void -> float)
    // 2. Wir müssen mit dem return statement angeben welcher Wert ausgegeben wird
    public float MultiplyNumbers(float zahl1, float zahl2)
    {
        float sum = zahl1 * zahl2;
        Debug.Log(sum);
        float x = 3;
        float u = 56;
        float i = 67;
        return sum;
    }

    public string SpamSpecific(string vorname, string nachname)
    {
        string result = vorname + nachname + nachname + nachname + nachname + nachname + nachname + nachname + nachname + nachname;
        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Aufruf der Funktion
        // 1. Name der Funktion!
        // 2. Parameterliste (Auch wenn sie leer bleibt)
        // 3. Semikolon ;
        Spam();

        // Aufruf der Funktion mit Input
        SpamMitInput("Ich will schlafen!!!!!");
        SpamMitInput("Wann hört endlich die Stunde auf!!!");


        // // Aufruf der Funktion mit Input
        //           =          24          * 2
        float result = MultiplyNumbers(3,8) * 2;

        Debug.Log(SpamSpecific("Wilfried","Gruber") + "Schönen Tag!!!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
