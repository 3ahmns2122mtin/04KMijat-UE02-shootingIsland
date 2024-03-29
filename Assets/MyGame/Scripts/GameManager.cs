
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const int maxHit = 10;
    public GameObject target;
    public GameObject parentOfTargets;
    public GameObject objCounter;
    public GameObject wonObj;
    public GameObject shootSound;
    public GameObject badTarget;
    public GameObject parentBadTarget;




    private Text textCounter;
    private bool won;
    private int score;


    // Start is called before the first frame update
    void Start()

    {
        textCounter = objCounter.GetComponent<Text>();
        won = false;
        InvokeRepeating("BadSpawn", 2f, 7f);
        InvokeRepeating("Spawn", 1f, 2f);
        wonObj.SetActive(false);

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

    private void BadSpawn()
    {
        float randomX = Random.Range(-400, 400);
        float randomY = Random.Range(-110, 110);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myBadTarget = Instantiate(badTarget, parentBadTarget.transform);
        myBadTarget.transform.localPosition = random2DPosition;

    }

        // Update is called once per frame
        void Update()
    {
        if(won == true)
        {
            CancelInvoke("Spawn");
            CancelInvoke("BadSpawn");
            wonObj.SetActive(true);
        }
        else
        {
            Debug.Log(won);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("increment ..." + score);
        textCounter.text = score.ToString();

        if(score == maxHit)
        {
            won = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed");
            shootSound.GetComponent<AudioSource>().Play();
        }
    }

    public void DecrementScore()
    {
        score--;
        Debug.Log("decrement ..." + score);
        textCounter.text = score.ToString();

        if (score == maxHit)
        {
            won = true;

        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed");
            shootSound.GetComponent<AudioSource>().Play();

        }
    }
}
