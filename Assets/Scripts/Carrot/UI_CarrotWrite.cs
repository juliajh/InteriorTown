using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CarrotWrite : MonoBehaviour
{
    private void Awake()
    {

        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
