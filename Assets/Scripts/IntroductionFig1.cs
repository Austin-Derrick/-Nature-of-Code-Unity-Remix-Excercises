using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionFig1 : MonoBehaviour
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
        walker.Step();

        walker.draw();
    }
}

public class Walker : MonoBehaviour
{
    GameObject walkerGO;

    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        walkerGO = this.gameObject;

        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Step()
    {
        float stepx = Random.Range(0, 4) - 1;
        float stepy = Random.Range(0, 4) - 1;

        x += stepx;
        y += stepy;

        walkerGO.transform.position = new Vector3(x, y, 0F);
    }

    public void draw()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        sphere.transform.position = new Vector3(walkerGO.transform.position.x, walkerGO.transform.position.y, 0f);
    }
}
