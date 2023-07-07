using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform Jogador;
    public float smooth;
    // Start is called before the first frame update
    void Start()
    {
        Jogador = GameObject.FindGameObjectWithTag("Jogador").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 Seguir = new Vector3(Jogador.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, Seguir, smooth * Time.deltaTime);
        
    }
}
