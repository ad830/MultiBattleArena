using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float speed = 6f;
    public float rotateSpeed = 100f;
    public float x;
    public float y;
    public float z;
    string key;
    Vector3 move;
    Vector3 rotate;
    Rigidbody playerRigidBody;
    Animator anim;
    //public Camera cam;
    bool runBack = false;
    float camx, camy, camz, camdist;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        Move(x, z);
        Turn();
        AnimateRun(x, z);
    }

    void Move(float x, float z)
    {
        move.Set(0f, 0f, z);
        move = move * speed * Time.deltaTime;
        if (z < 0)
        {
            move.z = move.z * -1;
        }
        //transform.position = transform.position + move;

        transform.Translate(move);
        
        if (z < 0 && !runBack)
        {
            transform.Rotate(new Vector3(0f, 180f, 0f));
            runBack = true;
        }
        else if (z > 0 && runBack)
        {
            transform.Rotate(new Vector3(0f, 180f, 0f));
            runBack = false;
        }
        //cam.transform.position = cam.transform.position + move;
    }

    void Turn()
    {
        if (x < 0)
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
            //cam.transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        else if (x > 0)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            //cam.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }

    void AnimateRun(float x, float z)
    {
        bool running = z != 0f;

        anim.SetBool("IsRunning", running);
    }

	// Update is called once per frame
	void Update () {
        //Nothing is probably gonna go here lol :P
        //camx = transform.transform.position.x;
        //camy = transform.transform.position.y;
        //camz = transform.transform.position.z;
        //camdist = 8f;

        //cam.transform.position = new Vector3(camx, 7f, camz - camdist);

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("IsRunning", false);
        }
        /*if (transform.position.y != 0.95f)
        {
            transform.position.Set(transform.position.x, 0.95f, transform.position.z);
        }*/
        //I lied :{D
	}

}
