using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "Ground")
        {
            Debug.Log("grounded");
            if (Input.GetAxis("Jump") > .01)
            {
                transform.Translate(0f, 10, 0f);
            }
        }
    }
    }
