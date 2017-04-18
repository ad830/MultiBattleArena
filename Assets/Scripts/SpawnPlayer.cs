using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour {

    public int players;
    public GameObject playerSword, playerBook, playerDagger, playerHammer, playerPolearm;
    public bool isSword, isBook, isDagger, isHammer, isPolearm;

    //public Transform[] spawn;
    public Vector3[] spawnLoc;
    public Quaternion[] spawnRot;

	// Use this for initialization
	void Start () {
        players = 1;
        isSword = true;

        spawnLoc[0] = new Vector3(0f, 0.95f, 0.4f);
        spawnLoc[1] = new Vector3(0f, 0.95f, -0.4f);
        spawnLoc[2] = new Vector3(0.4f, 0.95f, 0f);
        spawnLoc[3] = new Vector3(-0.4f, 0.95f, 0f);
        spawnLoc[4] = new Vector3(0.3f, 0.95f, 0.3f);
        spawnLoc[5] = new Vector3(0.3f, 0.95f, -0.3f);
        spawnLoc[6] = new Vector3(-0.3f, 0.95f, 0.3f);
        spawnLoc[7] = new Vector3(-0.3f, 0.95f, -0.3f);

        spawnRot[0] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[1] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[2] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[3] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[4] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[5] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[6] = new Quaternion(0f, 0f, 0f, 0f);
        spawnRot[7] = new Quaternion(0f, 0f, 0f, 0f);
/*
        for (int i = 0; i < 8; i++)
        {
            spawn[i].transform.position = spawnLoc[i];
            spawn[i].transform.rotation = spawnRot[i];
        }
*/
        Spawn();
	}
	
	void Spawn()
    {
        for (int i = 0; i < players; i++)
        {
            if (isSword)
            {
                Instantiate(playerSword, spawnLoc[i], spawnRot[i]);
            }
            else if (isBook)
            {
                Instantiate(playerBook, spawnLoc[i], spawnRot[i]);
            }
            else if (isDagger)
            {
                Instantiate(playerDagger, spawnLoc[i], spawnRot[i]);
            }
            else if (isHammer)
            {
                Instantiate(playerHammer, spawnLoc[i], spawnRot[i]);
            }
            else if (isPolearm)
            {
                Instantiate(playerPolearm, spawnLoc[i], spawnRot[i]);
            }
        }
        //Instantiate(player, spawnLoc[0], spawnRot[0]);
    }
}
