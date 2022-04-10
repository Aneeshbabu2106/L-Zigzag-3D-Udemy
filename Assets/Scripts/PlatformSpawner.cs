using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;

    Vector3 lastPos;
    float size;
    public bool gameOver = false;

    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;
        for(int i = 0; i < 20; i++)
        {
            PlatformSpawn();
        }
        InvokeRepeating("PlatformSpawn", 2f, 0.4f);
    }

    void Update()
    {
        if(gameOver)
        {
            CancelInvoke("PlatformSpawn");
        }
        
    }

    void PlatformSpawn()
    {
        int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            spawnX();
        }
        else
        {
            spawnZ();
        }
    }
    void spawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);
    }
    void spawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);

    }
}
