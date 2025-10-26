using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es2_w2d1 : MonoBehaviour
{
    [SerializeField] int a = 0;
    [SerializeField] int b = 0;
    [SerializeField] int c = 0;
    [SerializeField] int d = 0;

    // Start is called before the first frame update
    void Start()
    {
        int som = a+b+c+d;
        Debug.Log(som);
        int mol = a*b*c*d;
        Debug.Log(mol);
        int med =som/4;
        Debug.Log(med);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
