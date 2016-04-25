using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ammobombManager : MonoBehaviour {

    public ammobombManager AmmoBombManager;
    public static int ammo;        // The player's score.
    public static int bombs;


    Text text;                      // Reference to the Text component.

    // Use this for initialization
    void Awake ()
    {
        AmmoBombManager = GetComponent<ammobombManager>();

        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
    }

    // Update is called once per frame
    void Update ()
    {
        text.text = "Ammo: " + ammo / 7;
    }
}
