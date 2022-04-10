using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void StartGame()
    {
        UIManager.instance.StartGame();
        ScoreManager.instance.startScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawn();
    }

    public void GameOver()
    {
        UIManager.instance.GameOver();
        ScoreManager.instance.StopScore();
        gameOver = true;

    }
}
