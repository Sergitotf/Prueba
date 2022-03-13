using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
public class EnemiesController : MonoBehaviour
{
    [Serializable]

    public class EnemiesList
    {
        public GameObject[] enemies;
    }
    public EnemiesList[] enemiesLists;
    public int columNumber;
    public int[] rowNumber; //Array que almacena el numero de enemigos por cada columna
    public int columsActivated;
    public GameObject projectilePrefab;
    public float shootTimer = 1;
    public GameObject enemigos;


    public bool spaceToTheR = true;
    public bool spaceToTheL;
    public float movingTimer;
    public float movingTime = 2;

    public static EnemiesController instance;

   
    void Awake()
    {
        movingTimer = movingTime;
        if (EnemiesController.instance == null)
        {
            EnemiesController.instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        columNumber = enemiesLists.Length;
        //rowsDeactivated = enemiesLists.Length;

        for (int x = 0; x < enemiesLists.Length; x++)
        {
            rowNumber.SetValue(enemiesLists[x].enemies.Length, x);
        }
    }
    
    void Update()
    {
        //Region donde se encuentra el disparo de los aliens.
        #region
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0)
        {

            shootTimer = 1;
            bool seHaDisparado = false;

            while (!seHaDisparado)
            {
                columsActivated = 0;
                for (int r = 0; r < rowNumber.Length; r++)
                {
                    columsActivated += rowNumber[r];
                }
                if (columsActivated > 0)
                {
                    seHaDisparado = AlienShoot();
                    //Debug.Log("Se ha disparado " + seHaDisparado);
                }
                else
                {
                    seHaDisparado = true;
                }
            }
        }
        #endregion
        movingTimer -= Time.deltaTime; //Temporizador para el movimiento
        //Comprueba si hay espacio hacia la derecha y se mueve en esa dirección -9.7 a 3.7 = 12 en x
        if (spaceToTheR == true)
        {
            if (movingTimer <= 0)
            {
                enemigos.transform.Translate(Vector3.right * 2);
                movingTimer = movingTime;
            }

        }
        if (spaceToTheL == true)
        {
            if (movingTimer <= 0)
            {
                enemigos.transform.Translate(Vector3.left * 2);
                movingTimer = movingTime;
            }
        }
    }
    /// <summary>
    /// Funcion para hacer que el conjunto de aliens dispare. Además devuelve un booleano que indica si hay aliens o no.
    /// </summary>
    /// <returns></returns>
    public bool AlienShoot()
    {
        //Selecciono al azar una de las columnas.
        int colum = UnityEngine.Random.Range(0, enemiesLists.Length);
        //Debug.Log("Se ha escogido la columna " + colum);
        int lastActiveAlien = 0;
        bool hayAliens = true;
        if (rowNumber[colum] > 0)
        {
            //Ahora debo comprobar si en esa columna hay algún enemigo activo y de haberlo cuál es:
            for (int y = 0; y < enemiesLists[colum].enemies.Length; y++)
            {
                if (enemiesLists[colum].enemies[y].activeSelf == false && y == 0)
                {
                    hayAliens = false;
                    rowNumber.SetValue(0, colum);  //rownumber = {alienscoluman0, alienscolumna1, alienscolumna2....}
                    break;
                }
                else if (enemiesLists[colum].enemies[y].activeSelf == true)
                {
                    lastActiveAlien = y;
                    rowNumber.SetValue(lastActiveAlien + 1, colum);
                }
            }
            if (hayAliens)
            {
                //Ahora el último activo deve disparar:
                GameObject shooter = enemiesLists[colum].enemies[lastActiveAlien];
                GameObject projectileObject = Instantiate(projectilePrefab, shooter.transform.position + Vector3.down, Quaternion.Euler(90, 0, 0));
                Projectil projectile = projectileObject.GetComponent<Projectil>();
                projectile.SetObjective("Player");
                projectile.alienShooting = true;
                projectile.transform.localScale *= 0.5f;
                projectile.Launch(Vector3.down, 3000);
            }
            //Debug.Log("El ultimo activo es: " + lastActiveAlien);            
        }
        if (rowNumber[colum] == 0)
        {
            hayAliens = false;
        }
        return hayAliens;
    }

} */