using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject parentOfTargets;

    public bool won;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        won = false;

        InvokeRepeating("Spawn", 1f, 2f);

    }

    //Spawn a target at a randm position within a specified x and y range.
    //Instantiate (make a concret GameObject, i.e., a clone from the given prefabs target) the
    //target as child of the ParentOfTargets. In this case transform.localPosition instead of 
    //transform.position is important!!

    private void Spawn()
    {
        float randomX = Random.Range(-400, 400);
        float randomY = Random.Range(-150, 150);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;

        Debug.Log(random2DPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if(won == true)
        {
            CancelInvoke("Spawn");
        }
        else
        {
            Debug.Log(won);
        }

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed");
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("increment ..." + score);

        if(score > 10)
        {
            won = true;
        }
    }
}
