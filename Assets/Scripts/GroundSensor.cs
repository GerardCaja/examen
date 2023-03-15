using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   PlayerController controller;
   public bool isGrounded;

   private void Awake()
   {
        controller = GetComponentInParent<PlayerController>();
   }
   
   private void OnTriggerEnter2D(Collider2D collision)
   {
        isGrounded = true;
   }
   private void OnTriggerStay2D(Collider2D collision)
   {
        isGrounded = true;
   }
   private void OnTriggerExit2D(Collider2D collision)
   {
        isGrounded = false;
   }
}
