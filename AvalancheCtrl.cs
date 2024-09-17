using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvalancheCtrl : MonoBehaviour
{
    public bool isRolling;
    // Start is called before the first frame update
    void Start()
    {
        isRolling = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isRolling = true;
            Destroy(gameObject);
        }
    }
}
