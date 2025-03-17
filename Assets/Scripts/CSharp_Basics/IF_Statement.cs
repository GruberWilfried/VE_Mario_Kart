using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statement : MonoBehaviour
{
    void Start()
    {
        Vector3 a = Vector3.zero;
        Vector3 b = Vector3.zero;
        // IF Statements

        // Wir brauchen IF Statements wenn wir eine Entscheidung treffen möchten

        // Deklaration eiens IF-Statements

        // if  -> Keyword zum deklarieren
        // ()  -> Bedingung / Condition / Boolsche Expression
        //        Es kommt IMMER ein bool Wert heraus
        // {}  -> scope / Der Code der ausgeführt wenn der Wert true ist
        if (true)
        {
            Debug.Log("Hurrrraaahhhhh!!!!!");
        }

        // Vergleich von Werten

        // Vergleich von Zahlen (int / float / ...)
        // Vergleichsoperatoren
        //      ==        Gleich
        //      !=        Ungleich
        //      <         Kleiner
        //      <=        Kleiner Gleich
        //      >         Größer
        //      >=         Größer Gleich
        if (Vector3.Distance(a,b) > 5)
        {

        }

        // Vergleich von Strings
        // Vergleichsoperatoren
        //      ==        Gleich
        //      !=        Ungleich

        if ("test" != "fdsdf") // true
        {

        }

        if ("test" == "Test") // false
        {
            Debug.Log("ist richtig");
        }
        else
        {
            Debug.Log("ist falsch");
        }


        // IF-Statement mit Bool

        bool isGruberBald = false;
        if (isGruberBald)
        {

        }

        // Vergleich von Objekten
        // Vergleichsoperatoren
        //      ==        Gleich
        //      !=        Ungleich

        GameObject auto = new GameObject();
        GameObject meinAuto = new GameObject();

        if (auto == meinAuto) // false
        {

        }

        GameObject x = new GameObject();
        GameObject y = x;

        if (x == y) // true
        {

        }



        float myMoney = 70;
        if (myMoney > 100)  // false
        {
            Debug.Log("I am rich!!");
        }
        else
        {
            Debug.Log("I am Poor!!");
        }

        // Verschachteln von IF-Statements

        if (3 > 1)
        {
            if ("Hallo" == "hallo")
            {

            }
            else
            {

            }
        }
        
    }


}
