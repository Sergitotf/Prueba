using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour
{
    public float speed;
    public float heat;
    float nextShoot;

    public Spaceshipdata data;
    public GameObject projectilPrefab;
    Vector3 lookDirection = new Vector3(0, 1, 0);
    [SerializeField]
    Quaternion rotation;
    
    void Awake()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("EscenaJuego"))
        {
            gameObject.SetActive(true);
            data = GameDataPersistent.instance.selectedSpaceship;
            speed = data.speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("EscenaJuego"))
        {
            float horizontal = Input.GetAxis("Horizontal");
            Vector2 position = transform.position;
            position.x = position.x + 0.1f * horizontal * speed;
            transform.position = position;
        }
        if (nextShoot <= Time.time)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                nextShoot = Time.time + heat;
                Launch();
            }
        }
       
    }

    void Launch()
    {
        GameObject projectilObject = Instantiate(projectilPrefab, GetComponent<Rigidbody>().position + Vector3.up * 0.5f, rotation);

        Projectil projectil = projectilObject.GetComponent<Projectil>();
        projectil.Launch(lookDirection, 1000);
    }
}
