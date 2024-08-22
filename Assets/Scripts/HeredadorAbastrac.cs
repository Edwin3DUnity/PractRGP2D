using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeredadorAbastrac : ObtracPracitcaClass 
{
    public override string State {
        get
        {
            return _state;
        } set
        {
            _state = value;

        } 
    }

    public override void Initialize()
    {
        _state = "Manager Inicializado";
        Debug.Log(_state);
    }
    
}
