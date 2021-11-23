using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollLimb : MonoBehaviour
{
    Rigidbody2D rb;
    public float rotateSpeed, speed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 toTarget = -target.up.normalized;

        Vector3 cross = Vector3.Cross(toTarget, transform.right);
        float sign = Mathf.Sign(cross.z);
        rb.AddTorque(-sign * rotateSpeed);

        Vector3 goToTarget = (target.position - transform.position).normalized;
        rb.AddForce(goToTarget * speed);
    }
}
