using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public void OnCursorEnter(){
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    public void OnCursorExit(){
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
