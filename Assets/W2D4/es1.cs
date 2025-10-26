using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es1 : MonoBehaviour
{
    [SerializeField] private int index;
    [SerializeField] private int num;
    // Start is called before the first frame update
    void Start()
    {
        while (index >0)
        {
            ++num;
            --index;
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
