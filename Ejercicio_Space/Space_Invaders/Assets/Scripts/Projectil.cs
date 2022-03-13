using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectil : MonoBehaviour
{
    Rigidbody rigidbody;
    // private class SetObjective ;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.magnitude > 200.0f)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody.AddForce(direction * force);
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
