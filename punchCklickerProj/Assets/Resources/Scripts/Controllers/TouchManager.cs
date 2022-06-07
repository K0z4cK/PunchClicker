using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class TouchManager : SingletonComponent<TouchManager>
{
    [SerializeField] internal Camera cam;
    internal bool Raycast<T>(Vector2 touch, out T component) where T : Component
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(touch);
        print("TouchMammager raycast start origin" + ray.origin + " direct " + ray.direction);
        component = null;
        //RaycastHit[] hits = Physics.RaycastAll(ray,float.MaxValue);
        Debug.DrawRay(ray.origin, ray.direction * float.MaxValue, Color.red, 2);
        Physics.Raycast(ray, out hit, Mathf.Infinity);
        //foreach (RaycastHit hit in hits)
        //{
        print("TouchMammager raycast hit");
        if (hit.collider != null)
        {
            print(hit.collider);
            if (hit.collider.TryGetComponent(out component))
                return true;
        }
        //}
        return false;
    }
    // user touch event occurred
    internal void GetTouch()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase.Equals(TouchPhase.Began))
                {
                    GameManager.Instance.onTouchBeganUser(Input.GetTouch(0).position);
                }

                if (touch.phase.Equals(TouchPhase.Ended))
                {
                    GameManager.Instance.onTouchEndedUser(Input.GetTouch(0).position);
                }
            }
        }

        // Simulate touch events from mouse events
        if (Input.touchCount == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameManager.Instance.onTouchBeganUser((Vector2)Input.mousePosition);
            }
            if (Input.GetMouseButtonUp(0))
            {
                GameManager.Instance.onTouchEndedUser((Vector2)Input.mousePosition);
            }
        }
    }
    void Update()
    {
        GetTouch();
    }
}