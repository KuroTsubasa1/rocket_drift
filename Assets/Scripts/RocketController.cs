using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float thrustForce;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButton("Thrust"))
        {
            rb.AddForce(transform.forward * thrustForce);
        }
    }
}
