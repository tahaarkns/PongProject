using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Ball")
        {
            string goalName = transform.name;
            hitInfo.gameObject.SendMessage("RestartGame");
            GameManager.instance.Score(goalName);
        }
    }
}
    