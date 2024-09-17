using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceCreamTruck : MonoBehaviour

{
    public GameManager gM;
    public bool go = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(go == true)
        {
            StartCoroutine(iCTRoll());
        }
   
       
    }

    private void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.tag == "Player")
        {

            go = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            go = false;
        }
    }


    IEnumerator iCTRoll()
    {
        transform.Translate(0, 0, 0.4f);
        yield return new WaitForSeconds(3f);
        transform.Translate(0, 0, 0);
        yield return new WaitForSeconds(1f);
        transform.Translate(0, 0, -0.4f);
        yield return new WaitForSeconds(2f);
        transform.Translate(0, 0, 0);
        go = false;
        yield return null; 
    }
}
