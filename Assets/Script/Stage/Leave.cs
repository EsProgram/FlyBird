using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Leave : MonoBehaviour
{
  [SerializeField]
  private float speed = 1f;
  private bool leave = false;

  public void Update()
  {
    if(Input.touchCount > 0)
      leave = true;
    if(leave)
      transform.Translate(-Vector2.right * speed * Time.deltaTime);
  }

  public void OnBecameInvisible()
  {
    Destroy(gameObject);
  }
}
