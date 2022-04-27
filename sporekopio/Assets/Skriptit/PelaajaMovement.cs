using System.Collections;
using UnityEngine;

public class PelaajaMovement : MonoBehaviour
{
    Vector3 uusiPositio;
    Vector3 uusiKameraPositio;
    public float nopeus = 5f;


    void Start()
    {
        uusiPositio = transform.position;
    }

    
    void Update()
    {
        // Pelaajan liikutus
        if(Input.GetMouseButton(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                // Etäisyys hiiren klikistä
                float etax = transform.position.x - hit.point.x;
                float etaz = transform.position.z - hit.point.z;

                float eta = Mathf.Sqrt(etax * etax + etaz * etaz);

                if(hit.transform.gameObject.tag == "Lattia" && eta > 2)
                {
                    uusiPositio = new Vector3(hit.point.x, 1, hit.point.z);
                    transform.LookAt(uusiPositio);
                    float askel = nopeus * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, uusiPositio, askel);
                }
            }
        }

        // kameran liikutus
        float kameraetax = Camera.main.transform.position.x - transform.position.x;
        float kameraetaz = Camera.main.transform.position.z - transform.position.z;
        float kameraeta = Mathf.Sqrt(kameraetax * kameraetax + kameraetaz * kameraetaz);
        if(kameraeta>5)
        {
            uusiKameraPositio = new Vector3(transform.position.x, 17, transform.position.z);
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, uusiKameraPositio, kameraeta / 15*Time.deltaTime);
        }
    }
}
