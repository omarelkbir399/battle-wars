using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{

    //This is the speed of the racket mouvement
    public GameObject sword;
    public GameObject gameover;
    public float speed = 30;
    public float jump = 10;
        public Slider slider;
    int health = 120;
    private object keycode;
    private object getcomponent;

    private void FixedUpdate()
    {
        sword.SetActive(false);
        //This is our GetAxisRaw input 
        float v = Input.GetAxisRaw("Horizontal") * speed;

       
#pragma warning disable CS0618 // Le type ou le membre est obsolète
      #pragma warning restore CS0618 // Le type ou le membre est obsolète
      

//Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0);
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("walk", true);
        }
        else GetComponent<Animator>().SetBool("walk", false);

        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Animator>().SetTrigger("attack");
            sword.SetActive(true);

        }
    }

    private bool Getkeydown(object l)
    {
        throw new NotImplementedException();
    }

    private bool getkeydown(object l)
    {
        throw new NotImplementedException();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health -= 10;
            slider.value = health;
        }

        Debug.Log(health);
        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(slider.gameObject);
            gameover.SetActive(true);
        }
            

    }
}