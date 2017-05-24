using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject player;

    public static GameController Instance { get; set; }

    /// <summary>
    /// Awake
    /// </summary>
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    /// <summary>
    /// enable player movement
    /// </summary>
    public void EnablePlayerMovement()
    {
        var basicBehavior = this.player.GetComponent<BasicBehaviour>();
        if (basicBehavior != null)
        {
            basicBehavior.IsActive = true;
        }

        var moveBehavior = this.player.GetComponent<MoveBehaviour>();
        if (moveBehavior != null)
        {
            moveBehavior.IsActive = true;
        }
    }
}
