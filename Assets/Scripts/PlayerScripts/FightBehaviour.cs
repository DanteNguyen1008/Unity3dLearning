using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBehaviour : MonoBehaviour
{
    public Animator animator;
	// Use this for initialization
	void Start () {
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        this.animator.SetBool("combo1", Input.GetKey(KeyCode.K));
        this.animator.SetBool("combo2", Input.GetKey(KeyCode.J));
    }
}
