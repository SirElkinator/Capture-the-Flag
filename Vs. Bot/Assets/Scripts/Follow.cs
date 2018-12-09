using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public RectTransform healthbar1;
    int count;
    public GameObject Enemybullet;
    public GameObject otherObject;
    int hp = 100;
    int reload = 0;

    private bool sliding = false;
    private Vector3 slidingDirection;
    public Animator anim;
    public float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    void OnTriggerEnter(Collider otherObj)
    {

        //Takes damage from bullet

        if (otherObj.gameObject.tag == "Bullet")
        {
            
            hp = hp - 20;
            Destroy(otherObj.gameObject);
            if (hp == 0)
            {
                Destroy(gameObject, 0f);
                count = count + 1;
            }
        }
    }

    void Update () {
        anim = GetComponent<Animator>();
        anim.Play("Standard_Run");
        if (moveDirection.y > gravity * -1)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        controller.Move(moveDirection * Time.deltaTime);
        

        if (sliding)
        {
            controller.Move(slidingDirection * 2 * Time.deltaTime);
        }

        //Moves the cylinder

        float step = 5 * Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, otherObject.transform.position, step);
        
        transform.LookAt(otherObject.transform.position);

        healthbar1.sizeDelta = new Vector2(hp, healthbar1.sizeDelta.y);

        //Shoot at character
        if (reload == 0){
            Instantiate(Enemybullet, transform.position, transform.rotation);
            reload = 100;
        }
        reload = reload - 1;

    }
    
    
}