using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        print("Left click");
        EventManager.Instance.LeftClicked();
    }
}
