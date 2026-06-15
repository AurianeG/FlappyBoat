using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;


    void IncrementScore()
    {
        score++;
        print("Score: " + score);
    }

}
