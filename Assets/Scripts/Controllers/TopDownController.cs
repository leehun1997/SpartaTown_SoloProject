using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnClickEvent;

    protected CharacterStatsHandler stats { get; private set; }

    protected virtual void Awake()
    {
        stats= GetComponent<CharacterStatsHandler>();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallClickEvent(Vector2 direction)
    {
        OnClickEvent?.Invoke();
    }
}
