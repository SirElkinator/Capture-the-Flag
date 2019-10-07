using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagDestroy : MonoBehaviour
{
    public GameObject redFlag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        redFlag = GameObject.FindGameObjectWithTag("RedPickup");
    }
     void OnTriggerEnter(Collider otherObj)
    {
      if  (otherObj.gameObject == redFlag)
        {
            Destroy(redFlag);
            Debug.Log("Flaghitpole");
        }
    }
}
