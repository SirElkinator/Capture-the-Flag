using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlag : MonoBehaviour {
    public GameObject player;
    public GameObject newFlag;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject == player)
        {
            Instantiate(newFlag, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
