using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gabbia : MonoBehaviour
{
    collezionabile col=new collezionabile(10);
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Gabbia") && col.counter.Equals(10))
        {
            Destroy(collision.gameObject);
        }
    }
}
