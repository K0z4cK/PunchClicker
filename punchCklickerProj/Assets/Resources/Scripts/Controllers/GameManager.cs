using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
public class GameManager : SingletonComponent<GameManager>
{

    internal delegate void TouchBegan(Vector3 position);
    internal event TouchBegan TouchBeganUser;

    internal delegate void TouchMoved(Vector3 position);
    internal event TouchMoved TouchMovedUser;

    internal delegate void TouchEnded(Vector3 position);
    internal event TouchEnded TouchEndedUser;

    internal void onTouchBeganUser(Vector3 position)
    {
        // Debug.Log("Touch begin");
        TouchBeganUser?.Invoke(position);
    }
    internal void onTouchMovedUser(Vector3 position)
    {
        //Debug.Log("Touch Move");
        TouchMovedUser?.Invoke(position);
    }
    internal void onTouchEndedUser(Vector3 position)
    {
        //Debug.Log("Touch End");
        TouchEndedUser?.Invoke(position);
    }
}