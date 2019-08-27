using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour {
  
    private int count;
    public GameObject player;
    public GameObject flag;
    private bool decrease = false;
    float startpos;
    // Use this for initialization
    void Start () {
        count = 0;
        startpos = flag.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (decrease == true)
        {
            if (count > 0)
            {
                count = count - 1;
                
            }
            if (flag.transform.position.y < startpos)
            {
                flag.transform.Translate(0, .024f, 0);
            }
        }
        
        }
    void OnTriggerStay(Collider otherObj)
    {
      if  (otherObj.gameObject == player)
        {
            decrease = false;
            count = count + 1;
            if (flag.transform.position.y > 1){
                flag.transform.Translate(0, -.008f, 0);
            }
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
