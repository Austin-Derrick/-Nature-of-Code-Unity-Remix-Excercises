using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionFig2 : MonoBehaviour
{

    public List<int> randCount = new List<int>();
    public List<GameObject> cubes = new List<GameObject>();
    public GameObject cubeGO;

    int height = 1;

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(-1, randCount.Count);

        if (!randCount.Contains(index))
        {
            randCount.Add(index);
        }

        int w = 30 / randCount.Count;

        for (int x = 0; x < randCount.Count; x++)
        {
            if (randCount.Count < 100)
            {
                GameObject cube = Instantiate(cubeGO);
                cube.transform.position = new Vector3(w * x, height-randCount[x], 0f);
                cubes.Add(cube);
            }
            for (int y = 0; y < cubes.Count; y++)
            {
                cubes[y].transform.localScale = new Vector3(randCount[Random.Range(0, randCount.Count)], 1f);
            }
        }
    }
}
