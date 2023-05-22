using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int waveintIndex = 0;
    private GameObject manager;

    void Start()
    {
        
        target = Waypoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime);
        transform.GetChild(1).transform.LookAt(transform.position +dir * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }


    void GetNextWaypoint()
    {
        if (waveintIndex >= Waypoints.points.Length - 1)
        {
            manager = GameObject.Find("MANAGER");
            manager.GetComponent<PlayerHealth>().TakeDamage(1);
            
            Destroy(gameObject);
            return;
        }
        waveintIndex++;
        target = Waypoints.points[waveintIndex];
    }
}
