using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    TowerSpawner towerSpawner;
    public void Awake()
    {
        towerSpawner = TowerSpawner.ts;
        Debug.Log("took ts instance");
    }
    public void Purchase1()
    {
        Debug.Log("1");
        towerSpawner.SetTurret(towerSpawner.Turret1);
    }
    public void Purchase2()
    {
        Debug.Log("2");
        towerSpawner.SetTurret(towerSpawner.Turret2);
    }
    public void Purchase3()
    {
        Debug.Log("3");
        towerSpawner.SetTurret(towerSpawner.Turret3);
    }
    public void Purchase4()
    {
        Debug.Log("4");
        towerSpawner.SetTurret(towerSpawner.Turret4);
    }
}
