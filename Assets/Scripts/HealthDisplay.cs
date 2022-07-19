using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    Text healthText;
    Player playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        playerHealth = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerHealth.GetHealth().ToString();
    }
}
