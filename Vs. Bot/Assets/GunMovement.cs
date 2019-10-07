using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    int aimcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Aim") > .01)&&(aimcount < 1)){
            transform.Translate(-.1f,0f,.1f);
            aimcount = aimcount +1;
        }
        if (Input.GetAxis("Aim") == 0){
            aimcount = 0;
            //transform.Translate(1f,0f,-1f);
        }
    }
}
