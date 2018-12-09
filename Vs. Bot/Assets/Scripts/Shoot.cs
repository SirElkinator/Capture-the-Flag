using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public GameObject bullet;
    int bulletWait = 0;
    int ammo = 30;

    //Refills ammo
    void OnTriggerEnter(Collider otherObj){
        if (otherObj.gameObject.tag == "Ammo"){
            ammo = ammo + 30;
        }
    }

    void Update () {

        //Moves bullet out from player
        Vector3 playerPos = transform.position;
        Vector3 playerDirection = transform.forward;
        Quaternion playerRotation = transform.rotation;
        float spawnDistance = 1;
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        
            //Shoots the bullet
            if (Input.GetAxis("Fire1") > .98){
                bulletWait = bulletWait + 1;
                if (ammo > 1){
                    if (bulletWait >= 8){
                        Instantiate(bullet, spawnPos, playerRotation);
                        ammo = ammo - 1;
                        bulletWait = 0;
                    }
                }
            }

    }
}