using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraup : MonoBehaviour {

    public GameObject target;
    int distancestop = 1;
   
    void Update () {

        //Zooms camera in
        if (distancestop > 0){
            if (Input.GetAxis("Fire3") > .2){
                transform.Translate(0f, 0f, 5 * Time.deltaTime);
                distancestop = distancestop - 1;
            }
        }

        //Zooms camera in
        if (distancestop < 50){
            if (Input.GetAxis("Fire3") < -.2){
                transform.Translate(0f, 0f, -5 * Time.deltaTime);
                distancestop = distancestop + 1;
            }
        }
            
    }
}

