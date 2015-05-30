using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
  [SerializeField]
  private Rect spownRange = default(Rect);
  [SerializeField]
  private float spownRepeatTime = 1f;
  [SerializeField, Range(0.1f, 1f), Tooltip("出現確率")]
  private float spownRate = 0.5f;
  [SerializeField]
  private GameObject obstaclePrefab = null;

  public void Start()
  {
    InvokeRepeating("Spown", spownRepeatTime, spownRepeatTime);
  }

  private void Spown()
  {
    if(spownRate < UnityEngine.Random.Range(0f, 1f))
      return;

    var x = UnityEngine.Random.Range(spownRange.xMin, spownRange.xMax);
    var y = UnityEngine.Random.Range(spownRange.yMin, spownRange.yMax);
    Instantiate(obstaclePrefab, new Vector2(x, y), Quaternion.identity);
  }
}
