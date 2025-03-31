using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master03 : MonoBehaviour
{
    public Transform myTransform;
    public Vector3 newPos;
    public Vector3 newRot;
    public Vector3 newScale;
    public GameObject myGo;
    public bool goActive;
    public AudioSource myAudio;
    public AudioClip myClip;
    public SphereCollider myCol;
    public bool isTrigger;
    public Vector3 newCenter;
    public bool isEnabled;
    public Text myText;
    public Color myColor;
    public string myWriting;
    public Image myImage;
    public bool isTarget;
    public Sprite mySprite;
    public Color myImageColor;
    public MeshFilter filter;
    public Mesh newMesh;

    void Start()
    {
        myTransform.position = newPos;
        myTransform.localEulerAngles = newRot;
        myTransform.localScale = newScale;
        myGo.active = false;
        myAudio.clip = myClip;
        myCol.isTrigger = isTrigger;
        myCol.center = newCenter;
        myCol.enabled = isEnabled;
        myText.color = myColor;
        myText.text = myWriting;
        myImage.raycastTarget = isTarget;
        myImage.sprite = mySprite;
        myImage.color = myImageColor;
        filter.mesh = newMesh;
    }

}
