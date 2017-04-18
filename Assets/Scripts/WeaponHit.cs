using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour {

    Animator anim, animc;
    bool hitLeft;
    bool hitRight;
    int damage;
    PlayerStats stats;

	// Use this for initialization
	void Start () {
        //anim = gameobject.transform.parent.parent.GetComponent<Animator>();
        anim = gameObject.transform.parent.parent.GetComponent<Animator>();
        hitLeft = false;
        hitRight = false;
        damage = 25;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == gameObject.transform.parent.parent.name)
        {
            Physics.IgnoreCollision(gameObject.GetComponent<BoxCollider>(), collision.collider, true);
        }
        else
        {
            //Debug.Log(collision.impulse.magnitude);
            if (collision.impulse.magnitude > 0.025f)
            {
                collision.rigidbody.AddForce(0f, 0f, 10f, ForceMode.Impulse);
                stats = collision.gameObject.GetComponent<PlayerStats>();
                stats.hp = stats.hp - damage;
                animc = collision.gameObject.GetComponent<Animator>();
                if (hitRight)
                {
                    hitRight = false;
                    animc.SetBool("HitRight", hitRight);
                    hitLeft = true;
                    animc.SetBool("HitLeft", hitLeft);
                }
                else if (hitLeft)
                {
                    hitLeft = false;
                    animc.SetBool("HitLeft", hitLeft);
                    hitRight = true;
                    animc.SetBool("HitRight", hitRight);
                }
                else
                {
                    hitLeft = true;
                    animc.SetBool("HitLeft", hitLeft);
                }
                //Debug.Log("hit");
            }
        }
        //hitLeft = false;
        //hitRight = false;
        //animc.SetBool("HitLeft", hitLeft);
        //animc.SetBool("HitRight", hitRight);
    }

    void OnCollisionExit(Collision collision)
    {
        animc = collision.gameObject.GetComponent<Animator>();
        animc.SetBool("HitLeft", false);
        animc.SetBool("HitRight", false);
    }
}
