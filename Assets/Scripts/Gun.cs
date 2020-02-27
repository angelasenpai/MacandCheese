using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    float dmg, rng=500;
    GameObject bullet;
    Transform bTrans;


    // Start is called before the first frame update
    void Start()
    {
        bullet = Resources.Load("yellow") as GameObject;
        bTrans = bullet.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
    void shoot()
    {

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

             if (Input.GetButtonDown("Fire2"))
            {
                    
                if (Physics.Raycast(ray, out hit))
                {
                    var selection = hit.transform;
                if (selection.CompareTag("sponge"))
                {
                    Debug.Log("Happens ");
                    selection.transform.localScale -= new Vector3(0.5f,0.5f,0.5f)* Time.deltaTime;
                }

                                 
                    //tempBullet.transform.position += bullet.transform.TransformDirection(Vector3.forward) * Time.deltaTime*rng;

                    // tempBullet.transform.position = Vector3.MoveTowards(bTrans.position, selection.transform.position, Time.deltaTime * 12);

                     
                }
                
                
                    Vector3 spawnPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane));
                    GameObject tempBullet;

                   // tempBullet = Instantiate(bullet, spawnPoint, Quaternion.identity);
                   // tempBullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward* 100);

                

              }
        

    }
}
