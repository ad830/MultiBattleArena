using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeHit : MonoBehaviour {

    Animator anim;
    bool dodgeLeft;
    bool dodgeRight;
    CapsuleCollider col;
    Rigidbody rig;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        dodgeLeft = false;
        dodgeRight = false;
        rig = gameObject.GetComponent<Rigidbody>();
        col = gameObject.GetComponent<CapsuleCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                dodgeLeft = true;
                anim.SetBool("DodgeLeft", dodgeLeft);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                dodgeRight = true;
                anim.SetBool("DodgeRight", dodgeRight);
            }
        }
        else
        {
            dodgeLeft = false;
            dodgeRight = false;
            anim.SetBool("DodgeLeft", dodgeLeft);
            anim.SetBool("DodgeRight", dodgeRight);
        }
    }
}
