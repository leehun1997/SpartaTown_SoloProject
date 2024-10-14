using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }
    // Start is called before the first frame update
    public void OnClick()
    {
        //playerName = playerNameInput.GetComponent<InputField>().text;
        SceneManager.LoadScene("MainScene");
    }
}
