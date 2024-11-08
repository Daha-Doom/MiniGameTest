using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    Animator animator;
    float timerTime;
    bool stopTime = false;
    [SerializeField]
    TextMeshProUGUI timerTimeText, bestTimeText;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        timerTimeText.text = timerTime.ToString("F2");
        bestTimeText.text = SaveData.bestTime.ToString("F2");
    }

    private void Update()
    {
        if (!stopTime)
        {
            timerTime += Time.deltaTime;
            timerTimeText.text = timerTime.ToString("F2");
        }
    }

    public void StopTimer()
    {
        stopTime = true;

        if (timerTime < SaveData.bestTime)
        {
            SaveData.bestTime = timerTime;
            bestTimeText.text = SaveData.bestTime.ToString("F2");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StopTimer();
            animator.SetTrigger(AnimatorString.Victory);
        }
    }
}
