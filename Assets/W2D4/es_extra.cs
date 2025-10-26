using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es_extra : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(num * i);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
// utilizando un ciclo for stampare la tabbelina del 5