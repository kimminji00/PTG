﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.score += 20;
            gameObject.SetActive(false);
        }


    }
}
