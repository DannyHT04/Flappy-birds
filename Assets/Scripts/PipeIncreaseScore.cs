using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private AudioSource _point;

    private void Awake()
    {
        _point = GetComponent<AudioSource>();
    }
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
            _point.Play();
        }
   }
}
