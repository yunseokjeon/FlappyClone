using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D other)
    {
        Score.score++;
    }
}
