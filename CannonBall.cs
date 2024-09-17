using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    Rigidbody cRb;
    // Start is called before the first frame update
    void Start()
    {
        cRb = GetComponent<Rigidbody>(); ;
        Destroy(gameObject, 5f);
        cRb.AddForce(0,0,-20,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
