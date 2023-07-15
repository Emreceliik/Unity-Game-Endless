using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Karaktercan : MonoBehaviour
{
   public static int health = 5;
    public GameObject healthText;
    void Update()
    {
        healthText.GetComponent<Text>().text = " " + health;
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            health = 5;
        }
    }
}
