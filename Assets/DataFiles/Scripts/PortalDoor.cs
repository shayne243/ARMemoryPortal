﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PortalDoor : MonoBehaviour
{
    public Material[] PGMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collide)
    {
        if(collide.gameObject.CompareTag("MainCamera"))
        {
            if(transform.position.z > collide.transform.position.z)
            {
                foreach(Material mat in PGMat)
                {
                    mat.SetInt("stest", (int)CompareFunction.Equal);
                }
            }
            else
            {
                foreach(Material mat in PGMat)
                {
                    mat.SetInt("stest", (int)CompareFunction.NotEqual);
                }
            }
        }
    }
}
