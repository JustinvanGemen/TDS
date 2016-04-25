using UnityEngine;
using System.Collections;

public class DropBomb : MonoBehaviour {

    public Transform bombDrop;
    public AllahuAkhbar allahuAkhbar;
    private float bombs = 9;
    private float delayCounter = 0.0F;
    private float reloadDelay = 1F;

    public AudioClip impact;
    AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("e") && bombs > 0 && Time.time > delayCounter)
            {
            audio.PlayOneShot(impact, 0.7F);
            AllahuAkhbar bomb = Instantiate(allahuAkhbar, bombDrop.position, bombDrop.rotation) as AllahuAkhbar;
            bombs -= 1;
            }
        else if (Input.GetKeyDown("q"))
        {
            bombs = 9;
            delayCounter = Time.time + reloadDelay;
        }

    }
}
