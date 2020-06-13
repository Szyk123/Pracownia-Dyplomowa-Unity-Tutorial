using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnCollision : MonoBehaviour
{
    public float jumpHeight = 7f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
 

               // rb.AddForce(Vector3.up * jumpHeight);

        
    }
    [SerializeField]
    string strTag;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            
                this.rb.AddForce(Vector3.up * jumpHeight);


        }
    }
}
