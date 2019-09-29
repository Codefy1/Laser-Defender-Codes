
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    Text healthText;
    player player;

    // Use this for initialization
    void Start()
    {
        healthText = GetComponent<Text>();
        player = FindObjectOfType<player>();//finds object player at the start.
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = player.GetHealth().ToString(); //calls GetHealth function from player.cs
    }

}