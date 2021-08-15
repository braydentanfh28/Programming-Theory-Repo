using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeTextUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text welcomeText = gameObject.GetComponent<Text>();
        welcomeText.text = "Welcome " + GameManager.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
