using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatenkLib : MonoBehaviour
{
    public float PercentageToDecimal(float percentage)
    {
        return percentage /= 100;
    }

    public float DecimalToPercentage(float percentage)
    {
        return percentage *= 100;
    }
}

public class FSM
{
    Dictionary<System.Type, BaseState> StatesDictionary = new Dictionary<System.Type, BaseState>(); // Dictionary for States - String is the key
    public BaseState currentState;

    public FSM(params BaseState[] states)
    {
        foreach (BaseState state in states)
        {
            state.SetOwner(this);
            StatesDictionary.Add(state.GetType(), state);
        }
    }
    public void SwitchState(System.Type newState)
    {
        currentState?.OnExit();
        currentState = StatesDictionary[newState];
        currentState?.OnStart();
    }

    public void OnUpdate()
    {
        currentState?.OnUpdate();
    }

    public void OnExit()
    {
        currentState?.OnExit();
    }
}

public abstract class BaseState : MonoBehaviour
{
    protected FSM owner;
    public void SetOwner(FSM owner)
    {
        this.owner = owner;
    }
    public virtual void OnAwake()
    {

    }
    public abstract void OnStart();
    public abstract void OnUpdate();
    public abstract void OnExit();
}