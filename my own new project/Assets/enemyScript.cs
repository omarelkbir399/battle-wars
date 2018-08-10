using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour
{

    int health = 100;
    public Slider slider;
    private void Update()
    {
        GetComponent<Animator>().SetBool("skill_1",true);
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                health -= 10;
                slider.value = health;
            }
            
            Debug.Log(health);
            if (health <= 0)
            {
                Destroy(gameObject);
                Destroy(slider.gameObject);
            }


        }


    }
}

