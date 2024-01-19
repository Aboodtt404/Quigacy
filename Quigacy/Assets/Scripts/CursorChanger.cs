using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    void OnMouseEnter()
    {
        Cursor.SetCursor(Texture2D.whiteTexture, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
