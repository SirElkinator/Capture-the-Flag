using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject enemy;

    int killstreak = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (GameObject.Find("enemy") == null){
            Debug.Log("found");
            killstreak = killstreak + 1;
            Instantiate(enemy, transform.position, transform.rotation);
            
        }
    }
}
