using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buclewhile : MonoBehaviour
{
    public int repeticiones;
    public int maxRepeticiones;
    // Start is called before the first frame update
    void Start()
    {
        while (repeticiones < maxRepeticiones)
        {
            Debug.Log("Bailando");
                repeticiones++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
