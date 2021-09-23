using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameManager : MonoBehaviour
{
    public static NameManager instance;
    public static GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        //instance = this;
        DontDestroyOnLoad(this);
        //DontDestroyOnLoad(button);

    }

    // Update is called once per frame
    void Update()
    {
        //playerName = inputfield.text;
    }
}
