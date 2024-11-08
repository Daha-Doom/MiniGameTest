using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnLoadData : MonoBehaviour
{
    private void OnMouseUp()
    {
        SaveSystem saveSystem = GetComponent<SaveSystem>();

        saveSystem.LoadData();
    }
}
