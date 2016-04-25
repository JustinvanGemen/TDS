using UnityEngine;
using System.Collections;

public class AllahuAkhbar : MonoBehaviour
{
    private SphereCollider col;
    private GameObject Enemy;
    
    void Awake()
    {
        Debug.Log("Collider Acquired");
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        
    }

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 25f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (!other.isTrigger)
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
                ScoreManager.score +=100;
            }
        }
    }
}