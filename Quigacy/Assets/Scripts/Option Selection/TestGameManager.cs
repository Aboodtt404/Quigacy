using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
public void getPlayers()
    {
        GameManager gameManager = GameManager.instance;

        if (gameManager != null)
        {
            int numberOfPlayers = gameManager.GetNumberOfPlayers();

            Debug.Log("Number of Players: " + numberOfPlayers);
        }
        else
        {
            Debug.LogError("GameManager instance not found!");
        }
    }
}
