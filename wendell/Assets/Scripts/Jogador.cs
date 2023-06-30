using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField] public float velocidade;
    private Rigidbody2D rig;
   // private Animator anim;
   public int ForçaPulo;

   public bool Chao;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
       // anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rig.velocity = Vector2.right * velocidade;
           // anim.SetBool("isRun", true);
        } 
        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            rig.velocity = Vector2.left * velocidade;
           // anim.SetBool("isRun", true);
        }
        else
        {
            //anim.SetBool("isRun", false);
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

