using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmove : MonoBehaviour {
	
    //Gives bullet movement
	void Update () {
        transform.Translate(0f, 0f, Time.deltaTime * 30);
    }

}
