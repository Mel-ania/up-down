using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    public Player player;

    private void Update()
    {
        scoreDisplay.text = "SCORE " + score;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Obstacle") && player.health > 0)
        {
            score++;
            Debug.Log(score);
        }
    }
    
}
