using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es4_w2d1 : MonoBehaviour
{
    [SerializeField] int StartingNumber = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StartingNumber);
        StartingNumber++;
        Debug.Log(StartingNumber);
        StartingNumber++;
        Debug.Log(StartingNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
