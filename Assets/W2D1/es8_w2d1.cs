using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class es8_w2d1 : MonoBehaviour
{
    [SerializeField] int i;
    // Start is called before the first frame update
    void Start()
    {
        if (i == 10)
        {
            Debug.Log("A+");
        }
        else if (i == 9)
        {
            Debug.Log("A");
        }
        else if (i == 8) 
        {
            Debug.Log("B");
        }
        else if (i == 7)
        {
            Debug.Log("B");
        }
        else if(i == 6)
        {
            Debug.Log("C");
        }
        else if(i == 5)
        {
            Debug.Log("D");
        }
        else if(i == 4)
        {
            Debug.Log("F");
        }
        else if (i == 3)
        {
            Debug.Log("F");
        }
        else if (i == 2)
        {
            Debug.Log("F");
        }
        else if (i == 1)
        {
            Debug.Log("F");
        }
        else if (i == 0)
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
