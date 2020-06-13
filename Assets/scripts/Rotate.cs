using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
