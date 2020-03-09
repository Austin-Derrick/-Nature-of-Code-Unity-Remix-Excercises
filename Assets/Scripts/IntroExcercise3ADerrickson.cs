using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroExcercise3ADerrickson : MonoBehaviour
{

    public GameObject walkerPrefab;
    private GameObject walkerGO;
    private WalkerEx3 walker;

    // Start is called before the first frame update
    void Start()
    {
        GameObject walkerGameObject = new GameObject();
        walker = walkerGameObject.AddComponent<WalkerEx3>();

    }

    // Update is called once per frame
    void Update()
    {
        walker.step();
        walker.draw();
    }
}

public class WalkerEx3 : MonoBehaviour
{
    public int x;
    public int y;
    private float mouseY;
    private float mouseX;
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
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }

    public void step()
    {
        if (num < 0.1F)
        {
            x++;
        }
        else if (num < 0.2F)
        {
            x--;
        }
        else if (num < .3F)
        {
            y++;
        }
        else if (num < 0.4f)
        {
            y--;
        }
        else
        {
            x += Mathf.RoundToInt(mouseX);
            y += Mathf.RoundToInt(mouseY);
        }
        walkerGO.transform.position = new Vector3(x, y, 0F);
    }

    public void draw()
    {
        GameObject sphere = Instantiate(walkerGO);
        sphere.transform.position = new Vector3(walkerGO.transform.position.x, walkerGO.transform.position.y, 0F);
    }
}
