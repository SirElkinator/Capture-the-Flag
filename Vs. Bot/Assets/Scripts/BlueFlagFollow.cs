using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFlagFollow : MonoBehaviour {
    public GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Enemy");
    }
	
	// Update is called once per frame
	void Update () {
        float step = 30 * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }
}
