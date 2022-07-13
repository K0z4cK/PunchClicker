using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class EventManager : SingletonComponent<EventManager>
{
    internal UnityEvent itemCreate = new UnityEvent();
    internal UnityEvent itemDestroy = new UnityEvent();
    internal UnityEvent leftClick = new UnityEvent();
    internal UnityEvent rightClick = new UnityEvent();
    internal UnityEvent attackItem = new UnityEvent();
    internal UnityEvent updateScore = new UnityEvent();
    internal UnityEvent<int> timerTick = new UnityEvent<int>();
    internal UnityEvent endTimer = new UnityEvent();

    internal void ItemCreated() => itemCreate?.Invoke();
    internal void ItemDestroyed() => itemDestroy?.Invoke();
    internal void ItemAttack() => attackItem?.Invoke();
    internal void LeftClicked() => leftClick?.Invoke();
    internal void RightClicked() => rightClick?.Invoke();
    internal void ScoreUpdated() => updateScore?.Invoke();
    internal void TimerEnds() => endTimer?.Invoke();
    internal void OnTimerTick(int value) => timerTick?.Invoke(value);



}
