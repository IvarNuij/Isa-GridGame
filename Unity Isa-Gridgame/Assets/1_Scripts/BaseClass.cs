using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseClass : MonoBehaviour
{
    public enum Grids
    {
        temperature = 0,
        dirt = 1,
        water = 2,
        lava = 3,
    }

    public virtual void OnAwake()
    {

    }
    public virtual void OnStart()
    {

    }
    public virtual void OnUpdate()
    {

    }

    public virtual void OnPhysicsUpdate()
    {

    }
}