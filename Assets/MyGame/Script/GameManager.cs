using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Random.Range(4, 20));
    
        Spawn();
    }

    private void Spawn ()
    {
        float randomX = Random.Range(-100, 100);
        float randomY = Random.Range(-100, 100);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        Debug.Log(random2DPosition);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
