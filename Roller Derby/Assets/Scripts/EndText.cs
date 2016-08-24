using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndText : MonoBehaviour {
    public Text thisText;
    public int highScoreCandidate;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;

    // Use this for initialization
    void Start () {
    if(PlayerPrefs.GetInt("Won") == 0)
        {
            thisText.text = "You failed!";
        }
    else if (PlayerPrefs.GetInt("Won") == 1)
        {
            thisText.text = "Congratulations! You had " + PlayerPrefs.GetFloat("EndTime").ToString() + " remaining!";
            
        }
        detectHighScore();
	}
    public void detectHighScore()
    {
        highScoreCandidate = 0;

        // The shittiest implementation of a score-placing mecanism you've ever seen D:
        if (PlayerPrefs.HasKey("HighScore1"))
        {
            if (PlayerPrefs.GetFloat("EndTime") > PlayerPrefs.GetFloat("HighScore1"))
                highScoreCandidate = 1;
            else if (PlayerPrefs.HasKey("HighScore2"))
            {
                if (PlayerPrefs.GetFloat("EndTime") > PlayerPrefs.GetFloat("HighScore2"))
                    highScoreCandidate = 2;
            }
            else if (PlayerPrefs.HasKey("HighScore3"))
            {
                if (PlayerPrefs.GetFloat("EndTime") > PlayerPrefs.GetFloat("HighScore3"))
                    highScoreCandidate = 3;
            }
            else if (PlayerPrefs.HasKey("HighScore4"))
            {
                if (PlayerPrefs.GetFloat("EndTime") > PlayerPrefs.GetFloat("HighScore4"))
                    highScoreCandidate = 4;
            }
            else if (PlayerPrefs.HasKey("HighScore5"))
            {
                if (PlayerPrefs.GetFloat("EndTime") > PlayerPrefs.GetFloat("HighScore5"))
                    highScoreCandidate = 5;
            }
            }
        Debug.Log("EndTime is: " + PlayerPrefs.GetFloat("EndTime"));

        // Trust me, it gets worse :(
        if (highScoreCandidate == 1)
            highScore1.text = PlayerPrefs.GetFloat("EndTime").ToString();
        else if (highScoreCandidate == 2)
            highScore2.text = PlayerPrefs.GetFloat("EndTime").ToString();
        else if (highScoreCandidate == 3)
            highScore3.text = PlayerPrefs.GetFloat("EndTime").ToString();
        else if (highScoreCandidate == 4)
            highScore4.text = PlayerPrefs.GetFloat("EndTime").ToString();
        else if (highScoreCandidate == 5)
            highScore5.text = PlayerPrefs.GetFloat("EndTime").ToString();

    }
}
