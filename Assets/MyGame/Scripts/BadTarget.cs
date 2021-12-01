using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTarget : MonoBehaviour

{
    [SerializeField] private int secToDestroy;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        //secToDestroy = 2;
        //Destroy(gameObject, secToDestroy);
    }

    private void OnMouseDown()
    {
        gameManager.DecrementScore();
        Destroy(gameObject);
    }
}

