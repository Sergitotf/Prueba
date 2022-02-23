using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public GameObject caja;
    bool puertaAbierta;
    Rigidbody2D rigidbody2d;
    void OnTriggerEnter2D(Collider2D other)
    {
        /* RubyController controller = other.GetComponent<RubyController>();
         GameObject hit = Physics2D.caja(rigidbody2d.position);


         if (puertaAbierta == false)
         {
             if (hit.collider != null)
             {

                 puertaAbierta.SetActive == true;

             }
         }*/

    }

}

