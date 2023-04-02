using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeTower : MonoBehaviour
{
    public List<Transform> Targets = new List<Transform>();
    public List<Transform> DeadTargets = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Damage();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Targets.Add(other.gameObject.transform);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        Targets.Remove(other.gameObject.transform);
    }
    ///add this to caroutine 
    public void Damage()
    {
        foreach (var t in Targets)
        {
            if (t != null)
            {
                t.gameObject.GetComponent<EnemyHealth>().TakeDamage(10);

            }
            else
            {
                DeadTargets.Add(t);
            }
        }
        foreach (var t in DeadTargets)
        {
            Targets.Remove(t);
        }
        DeadTargets.Clear();
    }
}
