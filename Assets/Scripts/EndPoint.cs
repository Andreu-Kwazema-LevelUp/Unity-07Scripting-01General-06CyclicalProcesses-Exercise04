using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    #region Properties

    public bool IsEnter { get; private set; }

    #endregion
    

    #region Events

    public delegate void OnTriggerHandler();
    public event OnTriggerHandler OnTrigger;

    #endregion


    #region Unity Methods

    private void Start()
    {
        IsEnter = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsEnter)
        {
            IsEnter = true;
            OnTrigger?.Invoke();
        }
    }

    #endregion
}
