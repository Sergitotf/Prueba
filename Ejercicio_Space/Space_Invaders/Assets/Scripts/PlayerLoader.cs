using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    // Carga la instancia gamedatapersistant al iniciar el juego
    void Awake()
    {
        GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab);
        nave.transform.localScale *= 10f;
    }

   
}
