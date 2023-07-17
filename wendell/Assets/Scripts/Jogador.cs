using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField] public float velocidade;
    public int ForçaPulo;

    private bool isJumping;
    private bool doubleJump;
    
    private Rigidbody2D rig;
    private Animator anim;
  

   public bool Chao;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float movement = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movement * velocidade, rig.velocity.y);
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rig.velocity = new Vector2(this.velocidade, rig.velocity.y);
            anim.SetBool("isRun", true);
        } 
        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            rig.velocity = new Vector2(-this.velocidade, rig.velocity.y);
            anim.SetBool("isRun", true);
        }
        else
        {
            anim.SetBool("isRun", false);
        }

        if (Input.GetKey(KeyCode.Space) && Chao)
        {
            rig.AddForce(Vector2.up * ForçaPulo, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionStay2D()
    {
        Chao = true;
    }

    private void OnCollisionExit2D()
    {
        Chao = false;
    }
}

