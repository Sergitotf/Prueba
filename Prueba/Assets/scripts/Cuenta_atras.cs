using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuenta_atras : MonoBehaviour
{
    public float timer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.0f)
        {
            timer = timer - Time.deltaTime;
        }

        else if (timer <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}

