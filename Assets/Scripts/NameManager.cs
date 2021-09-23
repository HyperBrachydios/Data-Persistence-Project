using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameManager : MonoBehaviour
{
    public static NameManager instance;
    public InputField nameEntry;
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(this);
        //DontDestroyOnLoad(button);

    }

    // Update is called once per frame
    void Update()
    {
        //playerName = inputfield.text;
        //txt = this.InputField.text;
    }

    public void StartGame()
    {
        playerName = nameEntry.text;
    }
}
