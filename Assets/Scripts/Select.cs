using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(Ray,out hit))
        {
            var selection = hit.transform;
            if(selection.CompareTag("sponge"))
            {
                Debug.Log("You can select me <3");
            }

        }
    }
}
