using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManageri : MonoBehaviour
{
    public GameObject pelaajaPrefab;
    public GameObject lattiaTile;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(lattiaTile, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(pelaajaPrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
