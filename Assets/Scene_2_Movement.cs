using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_2_Movement : MonoBehaviour
{
   private Vector3 pos1 = new Vector3(-7,1,0);
     private Vector3 pos2 = new Vector3(1,1,0);
     public float speed = 1.0f;
 
     void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));
     }
 }   