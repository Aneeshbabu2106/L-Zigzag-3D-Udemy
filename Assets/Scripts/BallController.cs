using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;

    private bool started = false;
    private bool gameOver = false;
    Rigidbody rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(0,0,speed);
                started = true;
            }
        }
        if (!Physics.Raycast(transform.position,Vector3.down,1f))
        {
            rb.velocity = new Vector3(0, -25, 0);
            gameOver = true;
            Camera.main.GetComponent<CameraFollow>().gameOver = true;

        }
            
        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDir();
        }
    }

    void SwitchDir()
    {
        if (rb.velocity.x > 0 && rb.velocity.x > rb.velocity.z)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (rb.velocity.z > 0 && rb.velocity.x < rb.velocity.z)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Diamond")
        {
            Destroy(other.gameObject);

        }
    }
}
