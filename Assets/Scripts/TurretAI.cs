using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour
{
    private Transform target;
    public float detectRange = 15f;
    public string enemyTag = "Enemy";

    public Transform rotateJoint;

    void Start()
    {
        // To avoid performance issues, invoke the following method every set time instead of every frame.
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void Update()
    {
        if (target == null)
            return;

        // BLUE ARROW // Point at target if any.
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        rotateJoint.rotation = Quaternion.Euler (0f, rotation.y, 0f);
    }

    void UpdateTarget()
    {
        print("test");
        // If no enemy is found, set the shortestDistance to NaN to be safe.
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            // If the enemy is within range...
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        // Update the location of the enemy for the turret.
        if (nearestEnemy != null && shortestDistance <= detectRange)
        {
            target = nearestEnemy.transform;
        } else
        // Remove target if it's out of range.
        {
            target = null;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, detectRange);
    }
}
