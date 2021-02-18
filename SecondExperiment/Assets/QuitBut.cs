using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitBut : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitting");
    }
}
