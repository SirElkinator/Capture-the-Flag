using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    void Update () {

        //Turns camera left
        if (Input.GetAxis("Fire2") > .2){
            transform.Rotate(Vector3.up * Time.deltaTime * 90);
        }

        //Turns camera right
        if (Input.GetAxis("Fire2") < -.2){
            transform.Rotate(Vector3.down * Time.deltaTime * 90);
        }

      /* //Turns camera left
        if (Input.GetAxis("Fire3") > .2)
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 90);
        }

        //Turns camera right
        if (Input.GetAxis("Fire3") < -.2)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 90);
        }
        */
    }
}
