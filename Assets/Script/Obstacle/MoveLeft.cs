using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
  [SerializeField]
  private float speed = 5f;

  public void Update()
  {
    transform.Translate(-Vector2.right * speed * Time.deltaTime);
  }

  public void OnBecameInvisible()
  {
    Destroy(gameObject);
  }
}
