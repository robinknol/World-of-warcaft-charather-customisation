﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;

public class NewBehaviourScript : MonoBehaviour
{
    private float yPos = 55;
    private int diffrence = 45;
    public List<Image> images;
    public List<GameObject> things;
    private void Start()
    {
        for (int i = 0; i < images.Count; i++)
        {
            yPos -= diffrence;

            images[i].transform.localPosition = new Vector2(465, yPos);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (images[images.Count - 1].transform.localPosition.y != 10)
            {
                Position(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (images[0].transform.localPosition.y != 10)
            {
                Position(false);
            }
        }

        for(int i = 0; i < images.Count; i++)
        {
            if(images[i].transform.localPosition.y == 10)
            {
                for (int j = 0; j < things.Count; j++)
                {
                    things[j].SetActive(false);
                }
                things[i].SetActive(true);
            }
        }
    }

    private void Position(bool up)
    {
        switch (up)
        {
            case true:
                for (int i = 0; i < images.Count; i++)
                {
                    yPos = images[i].transform.localPosition.y;
                    yPos += diffrence;

                    images[i].transform.localPosition = new Vector2(465, yPos);
                }
                break;
            case false:
                for (int i = images.Count - 1; i > -1; i--)
                {
                    yPos = images[i].transform.localPosition.y;
                    yPos -= diffrence;

                    images[i].transform.localPosition = new Vector2(465, yPos);
                }
                break;
        }
    }
}
