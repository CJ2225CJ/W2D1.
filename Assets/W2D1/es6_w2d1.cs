using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es6_w2d1 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2)
        {
            Debug.Log(num1);
        }
        else
        {
            Debug.Log(num2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
