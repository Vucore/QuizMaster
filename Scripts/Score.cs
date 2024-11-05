using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int correctAnswers = 0;
    int questionSeen = 0;
    public int GetCorrectAnswer()
    {
        return correctAnswers;
    }
    public void SetCorrectAnswer()
    {
        correctAnswers++;
    }
    public int GetQuestionSeen()
    {
        return questionSeen;
    }
    public void SetQuestionSeen()
    {
        questionSeen++;
    }
    public int CaculateScore()
    {
        return Mathf.RoundToInt((correctAnswers/(float)questionSeen) * 100);
    }
}
