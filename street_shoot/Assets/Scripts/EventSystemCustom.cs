using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSystemCustom : MonoBehaviour
{
    public UnityEvent OnHeartIncrease;
    public UnityEvent OnHeartDecrease;
    public UnityEvent OnCoinIncrease;
    public UnityEvent OnCoinDecrease;
    public UnityEvent OnStarIncrease;
    public UnityEvent OnStarDecrease;



    void Awake()
    {
        OnHeartIncrease = new UnityEvent();
        OnHeartDecrease = new UnityEvent();
        OnCoinIncrease = new UnityEvent();
        OnCoinDecrease = new UnityEvent();
        OnStarIncrease = new UnityEvent();
        OnStarDecrease = new UnityEvent();

    }
}
