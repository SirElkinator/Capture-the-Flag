using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmove : MonoBehaviour {
	
    //Gives bullet movement
	void Update () {
        transform.Translate(0f, 0f, Time.deltaTime * 30);
    }
   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject, 0f);
        }
    }
}
