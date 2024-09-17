using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGhost : MonoBehaviour
{
    public GameObject ghost;
    int numOfGhosts = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (numOfGhosts > 0)
            {
                Instantiate(ghost, transform.position, transform.rotation);
                numOfGhosts--;
            }
        }
    }
}
