using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public int scorePlayer1;
    public int scorePlayer2;
    public TMP_Text uIScorePlayer1;
    public TMP_Text uIScorePlayer2;
    public TMP_Text uIWinTextCont;
    public GameObject uIWinLose;

    public static GameManager instance;
    public SceneManagement sceneManagement;
    public void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(gameObject);
    }
        
    public void Score(string GoalName)
    {
        if (GoalName == "GoalLeft")
        {
            scorePlayer2 += 1;
            uIScorePlayer2.text = scorePlayer2.ToString();
            Debug.Log("player2 scores");
            ScoreCheck();
        }
        
        else if (GoalName == "GoalRight")
        {
            scorePlayer1 += 1;
            uIScorePlayer1.text = scorePlayer1.ToString();
            Debug.Log("player1 scores");
            ScoreCheck();
        } 
    }  

    private void Delay()
    {
        sceneManagement.ChangeScene("Main Menu");
    }
    private void ScoreCheck()
    {
        if (scorePlayer1 == 10 )
        {
            uIWinLose.SetActive(true);
            uIWinTextCont.text = "Player 1 Wins";
            Invoke("Delay", 2.0f);
        }
        else if (scorePlayer2 == 10)
        {
             uIWinLose.SetActive(true);
            uIWinTextCont.text = "Player 2 Wins";
            Invoke("Delay", 2.0f);
        }
    } 
    
       
}
