using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutliplication : MonoBehaviour
{
    int Multiply(int a,int b){
        return a*b;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Multiplication Table of  number 5 is: ");
        for(int i=1;i<=10;i++){
            int result = Multiply(5,i);
            Debug.Log(5+" x "+i+" = "+result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
