using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BtnClicker : MonoBehaviour
{
    [SerializeField]
    private int score;

    [SerializeField]
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText.text = SaveData.clicks.ToString();
    }

    public void ClickClick()
    {
        score++;

        scoreText.text = score.ToString();

        SaveData.clicks = score;
    }
}
