using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es3_w2d1 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        int resto = num % 2;
        if (resto == 0)
        {
            Debug.Log("numero pari");
        }
        else
        {
            Debug.Log("numero dispari");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
