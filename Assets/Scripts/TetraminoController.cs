using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetraminoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movemet();


    }

    void Movemet()
    {
        this.transform.Translate(0, -1, 0);
        
    }
}
