using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyShips : MonoBehaviour
{
    [Serializable]

    public class EnemiesList
    {
        public GameObject[] enemies;
    }

    public EnemiesList[] enemiesList;
    
    void Start()
    {
        PrintArray();
    }
     void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++) // recorre enemielist
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)
            {
                if (enemiesList[x].enemies[y].activeSelf == true)
                {
                    Debug.Log(enemiesList[x].enemies[y].name);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            int lastX = enemiesList.Length - 1;
            int lastY = enemiesList[lastX].enemies.Length- 1;
            bool FoundLastActive = false;

            // bucle que calcula la ultima x e y

            for (int x = 0; x < enemiesList.Length; x++)
            {
                for (int y = 0; y < enemiesList[x].enemies.Length; y++)
                {
                    if (enemiesList[x].enemies[y].activeSelf == false && FoundLastActive == false) // Al encontrar el desactivado, para la busqueda
                    {
                        FoundLastActive = true;
                        Debug.Log("Encontrado el primero no activo x =" + lastX + "y =" + lastY);
                    }
                    else if(enemiesList[x].enemies[y].activeSelf == true && FoundLastActive == false)
                    {
                        lastX = x;
                        lastY = y;
                    }
                }
            }
            enemiesList[lastX].enemies[lastY].SetActive(false);
        }
    }
}
