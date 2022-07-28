using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{

    [Header("UI")]
    [SerializeField] TextMeshProUGUI finalScoreText;

    [Header("Scripts")]
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score of " +
                              scoreKeeper.CalculateScore() + "%";
    }
}
