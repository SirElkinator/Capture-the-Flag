using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour {
  
    private int count;
    public GameObject player;
    private bool decrease = false;
    // Use this for initialization
    void Start () {
        count = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        if (decrease == true)
        {
            if (count > 0)
            {
                count = count - 1;
            }
        }
        }
    void OnTriggerStay(Collider otherObj)
    {
      if  (otherObj.gameObject == player)
        {
            decrease = false;
            count = count + 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            decrease = true;
        }
    }

}
