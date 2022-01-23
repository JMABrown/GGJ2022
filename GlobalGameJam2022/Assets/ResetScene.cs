using System.Collections;
using System.Collections.Generic;
using Gamekit2D;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    private void Update()
    {
        if (PlayerInput.Instance.ResetScene.Down)
        {
            SceneManager.LoadScene(0);
        }
    }
}
