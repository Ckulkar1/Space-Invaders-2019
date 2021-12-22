using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{

    public GameObject projectilePrefab;

    void Shoot()
    {

        Instantiate(projectilePrefab, gameObject.transform.position, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Projectile")
        {
            Destroy(gameObject);


            // Get the game object, as a whole, that's attached to the Collider2D component
            Destroy(otherCollider.gameObject);



        }

        

        
    }
}
