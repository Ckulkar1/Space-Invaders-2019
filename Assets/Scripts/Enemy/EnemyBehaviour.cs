using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script controls the behaviour of each single Alien enemy
public class EnemyBehaviour : MonoBehaviour
{

    public AudioSource audio;

    public AudioClip explosion;

    public GameManager gameManager;

    public ScoreKeeping scoreKeeping;

    //public ScoreKeeping scoreKeeping;

    // Start is called before the first frame update
    void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        scoreKeeping = GameObject.Find("Text").GetComponent<ScoreKeeping>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	// A function automatically triggerred when another game object with Collider2D component
	// Enters the Collider2D boundaries on this game object
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
		// Check the tag on the other game object. If it's the projectile's tag,
		//  destroy both this game object and the projectile
        if (otherCollider.tag == "Projectile")
        {
            scoreKeeping.scoreNum += 50;
            audio.PlayOneShot(explosion);
                        
            Destroy(gameObject);

            

            // Get the game object, as a whole, that's attached to the Collider2D component
             Destroy(otherCollider.gameObject);

            


        }

       

            if (otherCollider.tag == "Player")
        {
            Destroy(gameObject);

            Destroy(otherCollider.gameObject);

            audio.PlayOneShot(explosion);

            gameManager.GameOver();

        }
    }
}
