using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnLoadScence : MonoBehaviour
{
    [SerializeField]
    int scenceIndex;

    private void OnMouseUp()
    {
        SceneManager.LoadScene(scenceIndex);
    }
}
