﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Car")
        {
            Destroy(target.gameObject);
        }
    }
}
