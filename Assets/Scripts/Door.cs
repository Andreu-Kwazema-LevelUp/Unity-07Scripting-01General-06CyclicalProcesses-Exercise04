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
        _switcher.OnTrigger += OpenDoor;
    }

    private void OnDisable()
    {
        _switcher.OnTrigger -= OpenDoor;
    }

    #endregion


    #region Private Methods

    private void OpenDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
        _switcher.OnTrigger -= OpenDoor;
    }

    #endregion
}
