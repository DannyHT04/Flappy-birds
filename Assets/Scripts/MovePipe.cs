using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
   [SerializeField] private float _speed = 0.65f;
   private void Update()
   {
    // move the gameobject left with the speed of .65
    transform.position += Vector3.left * _speed * Time.deltaTime;
   }
}
