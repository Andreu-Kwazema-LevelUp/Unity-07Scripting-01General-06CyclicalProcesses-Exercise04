using UnityEngine;

public class Switcher : MonoBehaviour
{
    #region Properties

    public bool IsSwitched { get; private set;}

    #endregion


    #region Events

    public delegate void OnTriggerHandler();
    public event OnTriggerHandler OnTrigger;

    #endregion


    #region Unity Methods

    private void Start()
    {
        IsSwitched = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsSwitched)
        {
            IsSwitched = true;
            OnTrigger?.Invoke();
        }
    }

    #endregion
}
