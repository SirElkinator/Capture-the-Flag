using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public GameObject bullet;
    int bulletWait = 0;
    public int ammo = 30;

    void Update () {

        //Moves bullet out from player
        Vector3 playerPos = transform.position;
        Vector3 playerDirection = transform.forward;
        Quaternion playerRotation = transform.rotation;
         float spawnDistance = 1.3f;
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        spawnPos.y = spawnPos.y - .3f;
        spawnPos.x = spawnPos.x + .5f;

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
   
    public void showammo(int x)
    {
        ammo = ammo + x;
    }
}