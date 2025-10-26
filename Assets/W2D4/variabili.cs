using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField] class variabili : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        int c = a + b;

        int moltiplicazione = 2 * 2;
        int divisione = 4 / 2; // uliliza il primo valore 
        int modulo = 5 / 2; // utilizza il secondo valore 

        Debug.Log(moltiplicazione);
        Debug.Log(divisione);
        Debug.Log(modulo);
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
