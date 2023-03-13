using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{

    public GameObject prefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Check for left mouse button press
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from the mouse position
            RaycastHit hitInfo; // Store information about the object hit by the ray

            if (Physics.Raycast(ray, out hitInfo)) // Cast the ray and check if it hit an object
            {
                Vector3 spawnPos = hitInfo.point; // Set the spawn position to the point where the ray hit the object

                GameObject newObject = Instantiate(prefab, spawnPos, Quaternion.identity); // Instantiate the prefab at the spawn position
            }
        }
    }

}
