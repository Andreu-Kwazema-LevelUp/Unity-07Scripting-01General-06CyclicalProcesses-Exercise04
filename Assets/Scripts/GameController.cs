using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    #region Fields
    
    private EndPoint _endPoint;

    #endregion


    #region Unity LifeCycle

    private void Awake()
    {
        _endPoint = FindObjectOfType<EndPoint>();
    }

    private void OnEnable()
    {
        if (_endPoint != null)
            _endPoint.OnTrigger += GameOver;
    }

    private void OnDisable()
    {
        if (_endPoint != null)
            _endPoint.OnTrigger -= GameOver;
    }

    #endregion


    #region General Methods

    private void GameOver()
    {
        if (_endPoint != null)
            _endPoint.OnTrigger -= GameOver;

        SceneManager.LoadScene("GameOver");
    }

    #endregion
}
