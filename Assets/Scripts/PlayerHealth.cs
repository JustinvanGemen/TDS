using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;

    private PlayerMovement playermovement;
    private bool playerDead;

    void Awake () {
        playermovement = GetComponent<PlayerMovement> ();
	}
	
	void Update ()
    {
	if (health <= 0f)
        {
            Debug.Log("Destroy");
            //Destroy(gameObject);
            LevelReset();
        }
	}

    //void PlayerDying()
   // {
     //   playerDead = true;
    //}

   // void PlayerDead()
   // {
      //  playermovement.enabled = false;
   // }

    void LevelReset()
    {
        Debug.Log("Reset");
        ScoreManager.score -= 1000;
        SceneManager.LoadScene("Main");
    }



    public void ApplyDamage(float amount)
    {
        Debug.Log("ApplyDamage");
        health -= amount;
        
    }
}
