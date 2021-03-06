﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroExcercise1 : MonoBehaviour
{

    public GameObject walkerPrefab;
    private GameObject walkerGO;
    private Walker walker;

    // Start is called before the first frame update
    void Start()
    {
        GameObject walkerGameObject = new GameObject();
        walker = walkerGameObject.AddComponent<Walker>();

    }

    // Update is called once per frame
    void Update()
    {
        walker.step();
        walker.draw();
    }
}

public class Walker : MonoBehaviour
{
    public int x;
    public int y;
    float num;
    GameObject walkerGO;

    // Start is called before the first frame update
    void Start()
    {
        walkerGO = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        num = Random.Range(0f, 1f);
    }

    public void step()
    {
        if (num < 0.4F)
        {
            x++;
        }
        else if (num < 0.5F)
        {
            x--;
        }
        else if (num < .6F)
        {
            y++;
        }
        else
        {
            y--;
        }
        walkerGO.transform.position = new Vector3(x, y, 0F);
    }

    public void draw()
    {
        GameObject sphere = Instantiate(walkerGO);
        sphere.transform.position = new Vector3(walkerGO.transform.position.x, walkerGO.transform.position.y, 0F);
    }
}
