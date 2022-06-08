using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class EventManager : SingletonComponent<EventManager>
{
    internal UnityEvent<int> itemCreate = new UnityEvent<int>();
    internal UnityEvent itemDestroy = new UnityEvent();
    internal UnityEvent itemClick = new UnityEvent();
    internal UnityEvent<int> attackItem = new UnityEvent<int>();
    internal void ItemCreated(int maxHp) => itemCreate?.Invoke(maxHp);
    internal void ItemDestroyed() => itemDestroy?.Invoke();
    internal void ItemAttack(int damage) => attackItem?.Invoke(damage);
    internal void ItemClicked() => itemClick?.Invoke();

}
