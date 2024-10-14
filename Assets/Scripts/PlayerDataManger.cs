using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataManger : MonoBehaviour
{
    public static PlayerDataManger Instance;
    public string playerName = null;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance= this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetName(string name)
    {
        playerName = name;
    }

    public string GetName()
    {
        return playerName;
    }
}
