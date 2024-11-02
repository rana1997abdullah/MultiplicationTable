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
        for(int i=1;i<=10;i++){
            Debug.Log(5+" x "+i+" = "+Multiply(5,i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
