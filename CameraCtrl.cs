using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public Transform playerTR;           
    public float smoothing;
    public SphereCtrlTest sCT;

    Vector3 distanceBetweenCameraAndTarget;     


    void Start()
    {
        
        playerTR = GameObject.Find("player").GetComponent<Transform>();
        
        distanceBetweenCameraAndTarget = transform.position - playerTR.position;


    }


    void LateUpdate()
    {
       
        Vector3 targetCamPos = playerTR.position + distanceBetweenCameraAndTarget;

        

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

    }
}
