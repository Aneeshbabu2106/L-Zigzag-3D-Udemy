using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Text score;
    public Text highScore1;
    public Text highScore2;
    public Text tapText;

    public GameObject startPanel;
    public GameObject gameOverPanel;

    private void Start()
    {
        highScore2.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
    }
    private void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }
    }
    public void StartGame()
    {
        tapText.enabled = false;
        startPanel.GetComponent<Animator>().Play("PanelUp");
    }
    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("Score").ToString();
        highScore1.text = PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);

    }

}
