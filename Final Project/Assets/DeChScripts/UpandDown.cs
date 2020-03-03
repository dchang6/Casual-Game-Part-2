 using UnityEngine;
 using System.Collections;
 
 public class UpandDown: MonoBehaviour
 {
     public float speed = 1.5f;
 
     void Update ()
     {

         if (Input.GetKey(KeyCode.UpArrow))
         {
             transform.position += Vector3.up * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.DownArrow))
         {
             transform.position += Vector3.down * speed * Time.deltaTime;
         }
     }
 }
