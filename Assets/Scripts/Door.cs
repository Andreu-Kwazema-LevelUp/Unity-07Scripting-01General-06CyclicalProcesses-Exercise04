using UnityEngine;

public class Door : MonoBehaviour
{
    #region Fields

    private Switcher _switcher;

    #endregion


    #region Unity Methods

    private void Awake()
    {
        _switcher = FindObjectOfType<Switcher>();
    }

    private void OnEnable()
    {
        if (_switcher != null)
            _switcher.OnTrigger += OpenDoor;
    }

    private void OnDisable()
    {
        if (_switcher != null)
            _switcher.OnTrigger -= OpenDoor;
    }

    #endregion


    #region General Methods

    private void OpenDoor()
    {
        if (_switcher != null)
            _switcher.OnTrigger -= OpenDoor;

        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
    }

    #endregion
}
