using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    [SerializeField]public gameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = FindObjectOfType<gameController>();
    }

    private void Awake()
    {
        gc.returnScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
