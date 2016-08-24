using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndText : MonoBehaviour {
    public Text thisText;
    public int highScoreCandidate;

    public float[] highScores;

    public Text[] highScoreTexts;

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

        float endTime = PlayerPrefs.GetFloat("EndTime", 0);

        if (PlayerPrefs.GetInt("Won") == 0)
        {
            endTime = -1000000;
        }
        PlayerPrefs.SetFloat("HighScore1", 10);
        PlayerPrefs.SetFloat("HighScore2", 8);
        PlayerPrefs.SetFloat("HighScore3", 6);
        PlayerPrefs.SetFloat("HighScore4", 5);
        PlayerPrefs.SetFloat("HighScore5", 4);
        float highScore1 = PlayerPrefs.GetFloat("HighScore1", 5.00f);
        float highScore2 = PlayerPrefs.GetFloat("HighScore2", 4.00f);
        float highScore3 = PlayerPrefs.GetFloat("HighScore3", 3.00f);
        float highScore4 = PlayerPrefs.GetFloat("HighScore4", 2.00f);
        float highScore5 = PlayerPrefs.GetFloat("HighScore5", 1.00f);

        highScores = new float[] { highScore1, highScore2, highScore3, highScore4, highScore5};

        Debug.Log("EndTime is: " + endTime);

        if (endTime > highScores[0])
        {
            highScores[4] = highScores[3];
            highScores[3] = highScores[2];
            highScores[2] = highScores[1];
            highScores[1] = highScores[0];
            highScores[0] = endTime;
        }
        else if (endTime > highScores[1])
        {
                highScores[4] = highScores[3];
                highScores[3] = highScores[2];
                highScores[2] = highScores[1];
                highScores[1] = endTime;
        }
        else if (endTime > highScores[2])
        {
            highScores[4] = highScores[3];
            highScores[3] = highScores[2];
            highScores[2] = endTime;
        }
        else if (endTime > highScores[3])
        {
            highScores[4] = highScores[3];
            highScores[3] = endTime;
        }
        else if (endTime > highScores[3])
        {
            highScores[4] = endTime;
        }

        for (int i = 0; i < highScores.Length; i++)
        {
            highScoreTexts[i].text = highScores[i] + " s";
        }

        PlayerPrefs.SetFloat("HighScore1", highScores[0]);
        PlayerPrefs.SetFloat("HighScore2", highScores[1]);
        PlayerPrefs.SetFloat("HighScore3", highScores[2]);
        PlayerPrefs.SetFloat("HighScore4", highScores[3]);
        PlayerPrefs.SetFloat("HighScore5", highScores[4]);
    }
}
