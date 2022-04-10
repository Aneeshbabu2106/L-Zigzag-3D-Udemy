using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int highScore;

    public static ScoreManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", score);
    }
    void IncrementScore()
    {
        score += 1;
    }

    public void startScore()
    {
        InvokeRepeating("IncrementScore", 1f, .5f);
    }

    public void StopScore()
    {
        CancelInvoke("IncrementScore");
        PlayerPrefs.SetInt("Score", score);
        if(PlayerPrefs.HasKey("HighScore")){
            if(score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
