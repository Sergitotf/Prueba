using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.scale(gameObject, new Vector3(0f, 0f, 0f), 0f);
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 1.0f).setEaseOutBounce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
