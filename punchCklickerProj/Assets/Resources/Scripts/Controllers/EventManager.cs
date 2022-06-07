using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class EventManager : SingletonComponent<EventManager>
{
    internal UnityEvent itemClick = new UnityEvent();
    internal UnityEvent<int> attackItem = new UnityEvent<int>();
    internal void ItemAttack(int damage) => attackItem?.Invoke(damage);
    internal void ItemClicked() => itemClick?.Invoke();

}
