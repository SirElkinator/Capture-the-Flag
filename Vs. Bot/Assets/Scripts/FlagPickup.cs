using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour {
  
    private int count;
    public GameObject player;
    // Use this for initialization
    void Start () {
        count = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider otherObj)
    {
      if  (otherObj.gameObject == player)
        {
            count = count + 1;
            Debug.Log(count);
        }
    }
   
}
