using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordFight : MonoBehaviour {

    Animator anim;
    bool combo1, combo2, combo3, combo4, combo5, combo6;
    public float waitTime;
    public float curTime;
    public int buttonPressCount = 0;
    Vector3 fight_move;
    public bool IsFighting = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        combo1 = false;
        combo2 = false;
        combo3 = false;
        combo4 = false;
        combo5 = false;
        combo6 = false;
        curTime = 0f;
        waitTime = 0f;
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            buttonPressCount += 1;
            if (buttonPressCount < 7)
            {
                fight_move.Set(0f, 0f, 0.4f);
                transform.Translate(fight_move);
                waitTime += 0.48f;
            }
            if (curTime < waitTime)
            {
                IsFighting = true;
                switch (buttonPressCount)
                {
                    case 1:
                        combo1 = true;
                        anim.SetBool("Combo1", combo1);
                        break;
                    case 2:
                        combo2 = true;
                        anim.SetBool("Combo2", combo2);
                        break;
                    case 3:
                        combo3 = true;
                        anim.SetBool("Combo3", combo3);
                        break;
                    case 4:
                        combo4 = true;
                        anim.SetBool("Combo4", combo4);
                        break;
                    case 5:
                        combo5 = true;
                        anim.SetBool("Combo5", combo5);
                        break;
                    case 6:
                        combo6 = true;
                        anim.SetBool("Combo6", combo6);
                        break;
                    default:
                        break;
                }
            }
        }
        curTime += Time.deltaTime;
        if (curTime > waitTime)
        {
            buttonPressCount = 0;
            combo1 = false;
            combo2 = false;
            combo3 = false;
            combo4 = false;
            combo5 = false;
            combo6 = false;
            anim.SetBool("Combo1", combo1);
            anim.SetBool("Combo2", combo2);
            anim.SetBool("Combo3", combo3);
            anim.SetBool("Combo4", combo4);
            anim.SetBool("Combo5", combo5);
            anim.SetBool("Combo6", combo6);
            curTime = 0f;
            waitTime = 0f;
            IsFighting = false;
        }
    }

    public bool getIsFighting()
    {
        return IsFighting;
    }
}
