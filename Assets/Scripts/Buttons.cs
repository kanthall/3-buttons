using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] Canvas popup;

    [Header("Text")]
    [SerializeField] Text textToShow;

    [Header("Sound")]
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip testSound;
    [SerializeField] [Range(0, 1)] float testSoundVolume = 0.50f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            Button1();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Button2();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Button3();
        }
    }

    void Start()
    {
        textToShow.enabled = false;
        audio = GetComponent<AudioSource>();
        popup.enabled = false;
    }

    public void Button1 ()
    {
        Debug.Log("sound played");
        audio.PlayOneShot(testSound, testSoundVolume);
    }

    public void Button2 ()
    {
        Debug.Log("popup showed");
        popup.enabled = true;
    }

    public void Button3 ()
    {
        Debug.Log("text showed");
        StartCoroutine(textShow());
    }

    IEnumerator textShow ()
    {
        textToShow.enabled = true;
        yield return new WaitForSeconds(3);
        textToShow.enabled = false;
    }
}
