using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringEnemyCtrl : MonoBehaviour
{
    public float speed;
    public SphereCtrlTest SCT;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SCT.lose = true;
            Destroy(gameObject);
        }
    }


}
