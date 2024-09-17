using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseScreen : MonoBehaviour
{
    public GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gM.indexOfLevel == 5 && Input.GetKey(KeyCode.R))
        {
            gM.indexOfLevel = 0;
            gM.lives = 3;
            Application.LoadLevel(gM.indexOfLevel);
        }
    }
}
