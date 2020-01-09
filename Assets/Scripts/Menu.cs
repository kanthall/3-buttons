using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] Canvas popup;

    public void ClosePopup()
    {
        popup.enabled = false;
    }
}
