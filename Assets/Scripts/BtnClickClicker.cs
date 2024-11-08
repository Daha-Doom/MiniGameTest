using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BtnClickClicker : MonoBehaviour
{
    [SerializeField]
    private int score;

    [SerializeField]
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText.text = SaveData.clicks.ToString();
        score = SaveData.clicks;
    }

    private void OnMouseUp()
    {
        score++;

        scoreText.text = score.ToString();

        SaveData.clicks = score;
    }
}
