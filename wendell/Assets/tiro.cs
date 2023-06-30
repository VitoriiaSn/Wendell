using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.velocity = Vector2.right * velocidade;
     
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
    
}
