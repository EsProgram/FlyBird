using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour
{
  private Rigidbody2D rig2D = null;
  private Animator anim = null;
  [SerializeField]
  private float jumpSpeed = 10f;
  [SerializeField]
  private SceneLoader loader = null;

  public void Awake()
  {
    rig2D = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }

  public void Update()
  {
    foreach(var touch in Input.touches)
      if(touch.phase == TouchPhase.Began)
      {
        anim.SetTrigger("Fly");
        rig2D.velocity = Vector2.up * jumpSpeed;
        break;
      }
  }

  public void OnTriggerEnter2D(Collider2D collision)
  {
    if(collision.gameObject.tag == "Obstacle")
    {
      anim.SetTrigger("Ban");
      loader.LoadScene("Title");
      Destroy(gameObject);
    }
  }
}
