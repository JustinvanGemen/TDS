using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public static int score;        // The player's score.


    Text text;                      // Reference to the Text component.


    void Awake()
    {

        scoreManager = GetComponent<ScoreManager>();

        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}