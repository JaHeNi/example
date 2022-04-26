using System.Collections;
using UnityEngine;

public class PelaajaMovement : MonoBehaviour
{
    Vector3 uusiPositio;


    void Start()
    {
        uusiPositio = transform.position;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.gameObject.tag == "Lattia")
                {
                    uusiPositio = new Vector3(hit.point.x, 1, hit.point.z);
                    transform.position = uusiPositio;
                }
            }
        }
    }
}
