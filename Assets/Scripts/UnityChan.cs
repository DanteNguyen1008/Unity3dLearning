using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChan : MonoBehaviour
{
    public Rigidbody rBody;
    public Animator animator;
    private float inputH;
    private float inputV;
    private bool run;

	// Use this for initialization
	void Start ()
    {
        this.rBody = GetComponent<Rigidbody>();
        this.animator = GetComponent<Animator>();
        this.run = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown("1"))
        {
            // -1 is BaseLayer, 0f is how far the animation will be played (first start point)
            this.animator.Play("WAIT01", -1, 0f);
        }

        if (Input.GetKeyDown("2"))
        {
            // -1 is BaseLayer, 0f is how far the animation will be played (first start point)
            this.animator.Play("WAIT02", -1, 0f);
        }

        if (Input.GetKeyDown("3"))
        {
            // -1 is BaseLayer, 0f is how far the animation will be played (first start point)
            this.animator.Play("WAIT03", -1, 0f);
        }

        if (Input.GetKeyDown("4"))
        {
            // -1 is BaseLayer, 0f is how far the animation will be played (first start point)
            this.animator.Play("WAIT04", -1, 0f);
        }

        if (Input.GetKeyDown("5"))
        {
            // -1 is BaseLayer, 0f is how far the animation will be played (first start point)
            this.animator.Play("DAMAGED00", -1, 0f);
        }

        if (Input.GetKeyDown("6"))
        {
            // -1 is BaseLayer, 0f is how far the animation will be played (first start point)
            this.animator.Play("DAMAGED01", -1, 0f);
        }

        this.animator.SetBool("jump", Input.GetKey(KeyCode.Space));

        this.inputH = Input.GetAxis("Horizontal");
        this.inputV = Input.GetAxis("Vertical");

        this.animator.SetFloat("inputH", this.inputH);
        this.animator.SetFloat("inputV", this.inputV);
        this.animator.SetBool("run", this.run);

        float moveX = this.inputH * 20f * Time.deltaTime;
        float moveZ = this.inputV * 50f * Time.deltaTime;

        if (moveZ <= 0f)
        {
            moveX = 0f;
        } else
        {
            if(this.run)
            {
                moveZ *= 3f;
                moveX *= 3f;
            }
        }

        this.run = Input.GetKey(KeyCode.LeftShift);
        this.rBody.velocity = new Vector3(moveX, 0f, moveZ);
    }
}
