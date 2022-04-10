using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject player;
    public float lerpRate;
    Vector3 offset;

    void Start()
    {
        offset =  player.transform.position - transform.position;
    }

    void Update()
    {
        if(!gameOver)
        {
            Follow();
        }  
    }

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = player.transform.position - offset;
        pos = Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
