using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    Score score;
    void Awake()
    {
        score = FindAnyObjectByType<Score>();
    }
    public void ShowFinalScore()
    {
        finalScoreText.text = "Your Score: " + score.CaculateScore() + " %";
    }
   
}
