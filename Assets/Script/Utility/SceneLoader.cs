using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
  public void LoadScene(string sceneName)
  {
    Application.LoadLevelAsync(sceneName);
  }
}
