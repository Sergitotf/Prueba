using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    private static PointsManager instance;
    public static PointsManager instance;
   
    void Awake()
    {
        
    }

    public void AddPoints(int Points)
    {
        amountPoints = amountPoints + Points;
    }
    public int Points { get { return amountPoints; } }
    public int GetPoints()
    {
        return amountPoints;
    }
   
}
