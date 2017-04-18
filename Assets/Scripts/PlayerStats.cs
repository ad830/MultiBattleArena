using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int playerNo;
    public int hp;
    public int stamina;
    public bool IsDead;
    Animator anim;

	// Use this for initialization
	void Start () {
        hp = 100;
        stamina = 50;
        IsDead = false;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0)
        {
            IsDead = true;
        }
        if (IsDead)
        {
            anim.SetBool("Die", IsDead);
            GetComponent<MovePlayer>().enabled = false;
            GetComponent<PlayerSwordFight>().enabled = false;
        }
	}
}
