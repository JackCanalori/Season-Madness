using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnedGhost : MonoBehaviour
{
    public Rigidbody ghostRB;
    public bool isMoving = true;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving == true)
        {
            transform.Translate(speed, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pulse")
        {
            ghostRB.AddForce(20, 5, 20, ForceMode.Impulse);
            ghostRB.AddTorque(20, 20, 20);
            isMoving = false;
        }


        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
