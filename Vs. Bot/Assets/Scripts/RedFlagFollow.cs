using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlagFollow : MonoBehaviour {
    public GameObject player;
    
    
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        
	}
	
	// Update is called once per frame
	void Update () {
        float step = 30 * Time.deltaTime;
        Vector3 newspot = player.transform.position;
        newspot.y = player.transform.position.y + 2.5f;
        newspot.z = player.transform.position.z + 1;
        newspot.x = player.transform.position.x + 1;
        transform.position = Vector3.MoveTowards(transform.position, newspot, step);
    }
   
}
