using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseCtrlScript : MonoBehaviour
{
    public GameObject pulseAb;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) || Input.GetButton("Fire2")) && active == true)
        {
            Instantiate(pulseAb, transform.position, transform.rotation);
            StartCoroutine(activeAbility());
        }
    }

    IEnumerator activeAbility()
    {
        active = false;
        yield return new WaitForSeconds(1f);
        active = true;
        yield return null;
    }
}
