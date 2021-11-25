using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Records : MonoBehaviour
{
    public int record1;
    public int record2;
    public int record3;
    public void OnEnable()
    {
        record1 = PlayerPrefs.GetInt("Jugador1", 0);
        record2 = PlayerPrefs.GetInt("Jugador2", 0);
        record3 = PlayerPrefs.GetInt("Jugador3", 0);
    }

    
    public void SaveRecords()
    {
        PlayerPrefs.SetInt("Jugador1", record1);
        PlayerPrefs.SetInt("Jugador2", record2);
        PlayerPrefs.SetInt("Jugador3", record3);
        PlayerPrefs.Save();

    }
}
