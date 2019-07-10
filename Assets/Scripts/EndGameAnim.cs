using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameAnim : MonoBehaviour
{
    public GameManager gameManager;

    void EngGame()
    {
        gameManager.RestartLevel();
    }

}
