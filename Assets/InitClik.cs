using UnityEngine;
using Tabtale.TTPlugins;
public class InitClik : MonoBehaviour
{
    private static InitClik _instance;
    public static InitClik Instance { get { return _instance; } }
    
    void Awake (){
        Debug.Log("#### InitClik:: Awake: start");
        if (_instance != null && _instance != this) 
        { 
            Destroy(this.gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("#### InitClik:: Awake: setup");

        Setup();
        Debug.Log("#### InitClik:: Awake: end");

    }
    
    #region TTPCore
    /// <summary>
    /// Starts the process of initialization of the TTP services. It should be called at the start of the game.
    /// Call this method to initiate TT Plugins. It is required for all services to work as intended.
    /// </summary>
    public void Setup()
    {
        Debug.Log("#### InitClik:: Setup: start");

#if TTP_CORE
        Debug.Log("#### InitClik:: Setup: TTPCore.Setup start");
        TTPCore.Setup();
        Debug.Log("#### InitClik:: Setup: TTPCore.Setup end");
#endif
        Debug.Log("#### InitClik:: Setup: end");
    }
    #endregion
}