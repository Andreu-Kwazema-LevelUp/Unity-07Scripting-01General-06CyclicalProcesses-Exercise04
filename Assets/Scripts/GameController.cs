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
        _endPoint.OnTrigger += GameOver;
    }

    private void OnDisable()
    {
        _endPoint.OnTrigger -= GameOver;
    }

    #endregion


    #region Methods

    private void GameOver()
    {
        _endPoint.OnTrigger -= GameOver;
        SceneManager.LoadScene("GameOver");
    }

    #endregion
}
