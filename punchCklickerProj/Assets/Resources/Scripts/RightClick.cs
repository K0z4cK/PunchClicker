using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        print("Right click");
        EventManager.Instance.RightClicked();
    }
}
