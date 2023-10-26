using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class collezionabile : MonoBehaviour
{
    public int counter = 0;
    public collezionabile(int counter) {
        this.counter = counter;
    }
    public Canvas win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collezionabile"))
        {
            Destroy(collision.gameObject);
            counter++;
            Debug.Log("Collezionabili: " + counter);
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Gabbia") && counter == 10)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("vittoria"))
        {
            win.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
