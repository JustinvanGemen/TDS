using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

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
		if (other.CompareTag ("Enemy"))
        {
            ScoreManager.score += 150;
            Destroy (other.gameObject);
			Destroy (gameObject);
		}
        else if(other.CompareTag ("Wall"))
        {
            Destroy(gameObject);
        }
	}
}
