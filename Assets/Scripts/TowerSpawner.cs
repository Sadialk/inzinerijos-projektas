using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public static TowerSpawner ts;
    Currency money;
    public GameObject Turret1;
    public GameObject Turret2;
    public GameObject Turret3;
    public GameObject Turret4;
    public GameObject Turret5;
    public GameObject TurretToBuild;
    public int price;
    private void Awake()
    {
        ts = this;
        Debug.Log("set ts instance");
        money = Currency.money;
        Debug.Log("took money instance");
    }
    public GameObject GetTurret()
    {
        return TurretToBuild;
    }
    public void SetTurret(GameObject Turret)
    {
        TurretToBuild = Turret;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (money.GetCurrentCurrency() < price)
            {
                return;
            }
            else if (TurretToBuild != null)
            {
                money.AddCurrency(-price);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from the mouse position
                RaycastHit hitInfo; // Store information about the object hit by the ray

                if (Physics.Raycast(ray, out hitInfo)) // Cast the ray and check if it hit an object
                {
                    Vector3 spawnPos = hitInfo.point; // Set the spawn position to the point where the ray hit the object
                    GameObject newObject = Instantiate(TurretToBuild, spawnPos, Quaternion.identity); // Instantiate the prefab at the spawn position
                }

            }
        }

    }

}
