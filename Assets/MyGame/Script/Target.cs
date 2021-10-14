using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   [SerializeField] private int secToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        //secToDestroy = 2;
        //Destroy(gameObject, secToDestroy); 
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
   
    void Update()
    {
        
    }
}
