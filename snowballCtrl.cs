using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballCtrl : MonoBehaviour
{
    public AvalancheCtrl AvCt;
    public Rigidbody SBRb;
    public bool go = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AvCt.isRolling == true) 
        {
            go = true;
            

        }
        if(go == true)
        {
            SBRb.AddForce(0, -45, -40, ForceMode.Impulse);
            SBRb.AddTorque(0, 0, -60, ForceMode.Impulse);
        }
    }
}
