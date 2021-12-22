using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMultiplier : MonoBehaviour
{
    public GameObject enemyGroup;

    private EnemyController enemyController;

    // Start is called before the first frame update
    void Start()
    {
        enemyController = GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MultiplyEnemy()
    {
        Instantiate(enemyController, gameObject.transform.position, Quaternion.identity);
    }
}
