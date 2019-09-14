using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    void Update () {

        //Turns camera left
        if (Input.GetAxis("TurnCamera") > .2){
            transform.Rotate(Vector3.up * Time.deltaTime * 180);
        }

        //Turns camera right
        if (Input.GetAxis("TurnCamera") < -.2){
            transform.Rotate(Vector3.down * Time.deltaTime * 180);
        }

       
       
    }
}
