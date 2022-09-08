using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 7f;
    public float rotationSpeed = 250f;

    public Animator animator;

    private float x, y;
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0,x*Time.deltaTime*rotationSpeed,0);
        transform.Translate(0,0,y*Time.deltaTime*runSpeed);

        animator.SetFloat("XSpeed",x);
        animator.SetFloat("YSpeed",y);
    }
}
