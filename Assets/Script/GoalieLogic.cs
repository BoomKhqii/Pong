using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieLogic : MonoBehaviour
{
    public int typePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pong"))
        {
            Debug.Log("Player scored");
        }
    }
}
