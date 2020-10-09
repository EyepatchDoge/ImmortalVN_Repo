using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource btnClick;

    public void Onclick()
    {
        btnClick.Play();
    }
}
