using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
  public void Play()
    {
        sceneController.Loadscene(1);
    }
    public void Restart()
    {
        sceneController.Restart();
    }
    public void NextLevel()
    {
        sceneController.NextLevel();
    }
    public void SceneLoad(int sceneIndex) 
    {
        sceneController.Loadscene(sceneIndex);
    }

}
