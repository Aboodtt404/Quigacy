using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyTextOnClick : MonoBehaviour
{
    public TextMeshProUGUI textToCopy;

    public void CopyTextToClipboard()
    {
        string text = textToCopy.text;

        GUIUtility.systemCopyBuffer = text;

        Debug.Log("Text copied to clipboard: " + text);
    }
}
