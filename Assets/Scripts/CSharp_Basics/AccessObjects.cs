using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class AccessObjects : MonoBehaviour
{
    // 1. Ich lege meine Variable vom entsprechenden Typ an
    // 2. Ich weise der Variable einen Wert zu (Manuell -> Drag and Drop Unity)
    public Transform myTransform;
    public Rigidbody myRb;
    public BoxCollider myBox;
    public SpriteRenderer sr;
    public Button myButton;
    public VideoPlayer myVidPlayer;
    public TMP_Dropdown myDrop;
    public TMP_InputField myInput;
    public TextMeshProUGUI myText;

    private void Update()
    {
        // 3. Ich kann nun die entsprechend Variablen meines Objektes ändern
        myRb.useGravity = false;
        myRb.mass = 2;
        myText.text = "Gruber";
    }
}
