using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraup : MonoBehaviour {
       
       void Update(){
           if (transform.localRotation.x > -.4){
        if (Input.GetAxis("CameraUp") > .2)
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 90);
        }
           }
        //Turns camera right
        //if camera is less than straight up
        if (transform.localRotation.x < .4){
        if (Input.GetAxis("CameraUp") < -.2)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 90);
        }
        }
       }
}

