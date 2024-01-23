using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int numberOfPlayers;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void SetNumberOfPlayers(int selectedGameMode)
    {
        switch (selectedGameMode)
        {
            case 1:
                numberOfPlayers = 2; // 1v1
                break;
            case 3:
                numberOfPlayers = 6; // 3v3
                break;
            case 5:
                numberOfPlayers = 10; // 5v5
                break;
            default:
                numberOfPlayers = 2; // Default to 1v1
                break;
        }
    }

    public int GetNumberOfPlayers()
    {
        return numberOfPlayers;
    }

    public void On1v1ButtonClick()
    {
        SetNumberOfPlayers(1);
        Debug.Log("Number of Players: " + GetNumberOfPlayers());
    }

    public void On3v3ButtonClick()
    {
        SetNumberOfPlayers(3);
        Debug.Log("Number of Players: " + GetNumberOfPlayers());
    }

    public void On5v5ButtonClick()
    {
        SetNumberOfPlayers(5);
        Debug.Log("Number of Players: " + GetNumberOfPlayers());
    }
}
