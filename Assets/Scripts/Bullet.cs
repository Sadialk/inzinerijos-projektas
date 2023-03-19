using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 100f;

    public void Chase(Transform _target)
    {
        target = _target;
    }
    // Update is called once per frame
    void Update()
    {
        //if there is no target
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        
        //find direction for the bullet  to travel
        Vector3 dir = target.position - transform.position;
        float distance = speed * Time.deltaTime;
        
        //check  if the bullet reaches the  raget
        if (dir.magnitude <= distance)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distance, Space.World);
    }
    //placeholder for dealing  with enemies
    void DamageEnemy()
    {
        EnemyHealth enemy = target.GetComponent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(50);
        }
    }
    //if the target is hit destroy the bullet and damage the enemy
    void HitTarget()
    {
        DamageEnemy();
        Destroy(gameObject);
    }
}
