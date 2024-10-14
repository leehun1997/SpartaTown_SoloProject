using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public PlayerDataManger playerDataManger;
    public InputField playerNameInput;
    public static string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        playerDataManger= GameObject.Find("PlayerDataManger").GetComponent<PlayerDataManger>();
    }
    // Start is called before the first frame update
    public void OnClick()
    {
        playerName = playerNameInput.text;
        playerDataManger.SetName(playerName);
        SceneManager.LoadScene("MainScene");
    }
}
