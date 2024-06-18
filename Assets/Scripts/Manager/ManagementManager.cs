using UnityEngine;

public class ManagementManager : MonoBehaviour
{
    private static ManagementManager _instance;
    public static ManagementManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("ManagementManager").AddComponent<ManagementManager>();
            }
            return _instance;
        }
    }

    public GameManager _gameManager;
    public GameManager GameManager
    {
        get { return _gameManager; }
        set { _gameManager = value; }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(_instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}
