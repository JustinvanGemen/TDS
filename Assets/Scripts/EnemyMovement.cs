using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private GameObject _playerObj;
    private NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Awake ()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _playerObj = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        _navMeshAgent.SetDestination(_playerObj.transform.position);
    }

    //void OnTriggerEnter (Collider other)
    //{
        //if (other.CompareTag("Allah"))
        //Destroy(other.gameObject);
        //Destroy(gameObject);
    //}

}
