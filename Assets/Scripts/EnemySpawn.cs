using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{

    public GameObject enemy;                // The enemy prefab to be spawned.
    //public float spawnTime = 10F;            // How long between each spawn.
    public Transform spawner;

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Spawn", 20, 70);
    }
	
	// Update is called once per frame
	void Spawn ()
    {
        Instantiate(enemy, spawner.position, spawner.rotation);
    }
}
