using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadController : MonoBehaviour
{
    public GameObject road1, road2;
    Vector3 road1Size,road2Size;


    // Start is called before the first frame update
    void Start()
    {
        road1Size = road1.transform.GetChild(0).GetComponent<Renderer>().bounds.size;
        road2Size = road2.transform.GetChild(0).GetComponent<Renderer>().bounds.size;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "triggerOne":
                road1.transform.position -= new Vector3(road1Size.x*2, 0, 0);
                break;

            case "triggerTwo":
                road2.transform.position -= new Vector3(road2Size.x*2, 0, 0);
                break;

            
        }
        
    }
}
