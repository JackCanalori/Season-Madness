using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombCtrl : MonoBehaviour
{
    Animator zombMotion;
    // Start is called before the first frame update
    void Start()
    {
        zombMotion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            zombMotion.SetBool("activate", true);
        }
    }
}
