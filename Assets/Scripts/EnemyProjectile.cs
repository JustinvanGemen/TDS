using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour
{

    private float _speed = 1;

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    public void SetSpeed(float value)
    {
        _speed = value;
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            
            //gameObject.SendMessage("ApplyDamage", 5, SendMessageOptions.DontRequireReceiver);
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth.ApplyDamage(5f);
        }
    }
}
