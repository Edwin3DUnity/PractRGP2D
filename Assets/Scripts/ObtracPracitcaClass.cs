using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObtracPracitcaClass
{
    protected string _state;
    public abstract string State { get; set; }

    public abstract void Initialize();
}
