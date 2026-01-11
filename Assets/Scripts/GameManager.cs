using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 5;

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }

    public void addLives(int value)
    {
               lives += value;
        Debug.Log("Lives: " + lives);
    }

    public void removeLives(int value)
    {
        lives -= value;
        Debug.Log("Lives: " + lives);
    }
}
