using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public string joystickButton10;
    public RectTransform healthbar;
    private bool sliding = false;
    private Vector3 slidingDirection;
    public Animator anim;
    public float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;
    int myhp = 100;
    int returnhealth = 0;

    void Update () {

        if (Input.GetKeyDown("g"))
        {
            Time.timeScale = 0;
            
        }

        if (Input.GetKeyUp("g"))
        {
            Time.timeScale = 1;
        }

        //Fall
        if (moveDirection.y > gravity * -1){
            moveDirection.y -= gravity * Time.deltaTime;
        }

        controller.Move(moveDirection * Time.deltaTime);
        anim = GetComponent<Animator>();

        if (sliding){
            controller.Move(slidingDirection * 2 * Time.deltaTime);
        }

        if (Input.GetAxis("Jump") > .01)
        {
            transform.Translate(0f, 1, 0f);
        }



        //Walks
        if (Input.GetAxis("Submit") > .01)
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 22, 0f, Input.GetAxis("Vertical") * Time.deltaTime * 22);
        }
        else
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, 0f, Input.GetAxis("Vertical") * Time.deltaTime * 10);
        }
        //Animates the run
        if (Input.GetAxis("Vertical") > 0.2 || Input.GetAxis("Vertical") < -0.2 || Input.GetAxis("Horizontal") > 0.2 || Input.GetAxis("Horizontal") < -0.2){
            anim.Play("Standard_Run");
        }
        else{
            anim.Play("Standard_Idle");
        }

        //Restore health if at half but wait

        if (myhp < 50){
            returnhealth = returnhealth + 1;
        }

        if (returnhealth > 1000){
            myhp = myhp + 10;
        }

        //Stop restoring health if full

        if (myhp == 100){
            returnhealth = 0;
        }
       

        //Healthbar adjustment
        healthbar.sizeDelta = new Vector2(myhp, healthbar.sizeDelta.y);

    }

    void OnTriggerEnter(Collider otherObj){

        if (otherObj.gameObject.tag == "Ground")
        {
            Debug.Log("grounded");
            
        }

        //Takes damage from bullet

        if (otherObj.gameObject.tag == "enemybullet"){
            
            myhp = myhp - 10;
            if (myhp == 0){
                Debug.Log("dead");
                
            }
        }

        //Restore health from pickup

        if (otherObj.gameObject.tag == "Health"){
            myhp = myhp + 20;
        }
    }
    
}