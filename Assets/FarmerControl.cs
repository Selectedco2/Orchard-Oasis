using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update

    [SerializeField]
    float speed = 5.5f;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        {

            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            Vector2 movementX = new Vector2(moveX, 0);
            Vector2 movementY = new Vector2(0, moveY);

            Vector2 movement = movementX + movementY;

            transform.Translate(movement * speed * Time.deltaTime);

            if (moveY > 0)
            {
                animator.Play("UpWalk");
            }
            else if (moveY < 0)
            {
                animator.Play("DownWalk");
            }
            else if (moveX < 0)
            {
                animator.Play("LeftWalk");
            }
            else if (moveX > 0)
            {
                animator.Play("RightWalk");
            }
            else
            {
                animator.Play("idle");
            }

        }
    }
}

