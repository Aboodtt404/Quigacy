using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject oneVone;
    public GameObject threeVthree;
    public GameObject fiveVfive;

    private int gameMode;

    public void GetGameMode()
    {
        GameManager gameManager = GameManager.instance;

        if (gameManager != null)
        {
            gameMode = gameManager.GetNumberOfPlayers();

            switch (gameMode)
            {
                case 0:
                    oneVone.SetActive(true);
                    threeVthree.SetActive(false);
                    fiveVfive.SetActive(false);
                    break;
                case 1:
                    oneVone.SetActive(false);
                    threeVthree.SetActive(true);
                    fiveVfive.SetActive(false);
                    break;
                case 2:
                    oneVone.SetActive(false);
                    threeVthree.SetActive(false);
                    fiveVfive.SetActive(true);
                    break;
                default:
                    oneVone.SetActive(true);
                    threeVthree.SetActive(false);
                    fiveVfive.SetActive(false);
                    break;
            }
        }
        else
        {
            oneVone.SetActive(true);
            threeVthree.SetActive(false);
            fiveVfive.SetActive(false);
        }
    }
}
