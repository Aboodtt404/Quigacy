using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    void Start()
    {
        GameManager gameManager = GameManager.instance;

        if (gameManager != null)
        {
            int numberOfPlayers = gameManager.GetNumberOfPlayers();

            Debug.Log("Number of Players: " + numberOfPlayers);
        }
        else
        {
            Debug.LogError("You have no chosen a game mode!");
        }
    }
}
