using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.velocity = new Vector3(speed, 0, 0);
        Debug.Log("fxspeed");
    }

    void Update()
    {
        SwitchDir();
    
    }

    void SwitchDir()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (rb.velocity.x > 0 && rb.velocity.x > rb.velocity.z)
            {
                Debug.Log(rb.velocity);
                rb.velocity = new Vector3(0, 0, speed);
                Debug.Log("xspeed");
                
            }
            else if (rb.velocity.z > 0 && rb.velocity.x < rb.velocity.z)
            {
                Debug.Log(rb.velocity);
                rb.velocity = new Vector3(speed, 0, 0);
                Debug.Log("zspeed");
                
            }

        }
    }
}
