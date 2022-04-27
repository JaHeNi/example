using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManageri : MonoBehaviour
{
    public GameObject pelaajaPrefab;
    public GameObject lattiaTile;

    void spawnLattia(int x, int y)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i=-2; i<3; i++)
        {
            for(int j=-2; j<3; j++)
            {
                Instantiate(lattiaTile, new Vector3(10*i, 0, 10*j), Quaternion.identity);
            }
        }
        Instantiate(pelaajaPrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
