using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnCloseApp : MonoBehaviour
{
    private void OnMouseUp()
    {
        SaveSystem saveSystem = GetComponent <SaveSystem>();

        saveSystem.SaveAll();

        Application.Quit();
    }
}
