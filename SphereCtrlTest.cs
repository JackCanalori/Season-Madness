using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCtrlTest : MonoBehaviour
{
    public Rigidbody playerRB;
    public float rollSpeed;
    public float jumpForce;
    public bool isOnPlatform = false;
    public Transform playerTR;
    Vector3 resetPoint;
    public GameManager gM;
    public bool lose = false; 

    // Start is called before the first frame update
    void Start()
    {
        resetPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float rollUpandDown = Input.GetAxis("HatY"); //returns a value in the range of -1 to + 1 from the dpad joy 
        float rollLeftandRight = Input.GetAxis("HatX");

        if (gM.lives > 0)
        {
            //playerRB.AddTorque(new Vector3(rollLeftandRight, 0, -rollUpandDown) *rollSpeed);
            if (Input.GetKey(KeyCode.W) || rollUpandDown > 0)
            {
                playerRB.AddTorque(rollSpeed, 0, 0);
            }

            if (Input.GetKey(KeyCode.S) || rollUpandDown < 0)
            {
                playerRB.AddTorque(-rollSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D) || rollLeftandRight > 0)
            {
                playerRB.AddTorque(0, 0, -rollSpeed);
            }
            if (Input.GetKey(KeyCode.A) || rollLeftandRight < 0)
            {
                playerRB.AddTorque(0, 0, rollSpeed);
            }
            if ((Input.GetKey(KeyCode.Space) || Input.GetButton("Fire1")) && isOnPlatform == true)
            {
                playerRB.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
            if (gM.hitCheckpoint == true)
            {
                setCheckPoint();
                gM.hitCheckpoint = false; 
            }

            if(gM.hitGhost == true)
            {
                transform.position = resetPoint;
                gM.hitGhost = false;
            }

            if(lose == true)
            {
                transform.position = resetPoint;
                gM.lives--;
                lose = false;
            }

            if (Input.GetButton("Home"))
            {

                Application.Quit();
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lose")
        {
            if (gM.lives > 0)
            {
                playerRB.velocity = new Vector3(0, 0, 0);
                transform.position = resetPoint;
                gM.lives--;
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
            {
            isOnPlatform = true;
            }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isOnPlatform = false;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ghost")
        {
            if (gM.lives > 0)
            {
                playerRB.velocity = new Vector3(0, 0, 0);
                transform.position = resetPoint;
                gM.lives--;
            }
        }

        if(other.gameObject.tag == "KillSpring")
        {
            Destroy(other.gameObject);
        }
    }



    void setCheckPoint()
    {
        resetPoint = transform.position;
    }
}
