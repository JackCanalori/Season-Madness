using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostCtrl : MonoBehaviour
{
    public Rigidbody ghostRB;
    public Transform playerTR;
    public float speed;
    public GameManager gM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTR);
        transform.Rotate(0, 210, 0);
        transform.Translate(0, 0, -speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pulse")
        {
            ghostRB.AddForce(20, 5, 20, ForceMode.Impulse);
            ghostRB.AddTorque(20,20,20);
        }


       if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
