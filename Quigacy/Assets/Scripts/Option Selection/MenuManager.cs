using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI codeText;

    void Start()
    {
        string randomCode = GenerateRandomCode();
        codeText.text = randomCode;
    }

    string GenerateRandomCode()
    {
        const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        System.Text.StringBuilder codeBuilder = new System.Text.StringBuilder();

        for (int i = 0; i < 6; i++)
        {
            int randomIndex = Random.Range(0, characters.Length);
            codeBuilder.Append(characters[randomIndex]);
        }

        return codeBuilder.ToString();
    }
}
