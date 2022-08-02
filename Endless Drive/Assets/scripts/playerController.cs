using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public Transform camera,player;
    public GameObject endScene;


    float speed = 50;
    bool dragging;
    bool drive = true;

    Touch finger;
    Vector3 firstPos, endPos, playerPosition;

    private void Start()
    {
        endScene.SetActive(false);
    }

    void Update()
    {
        playerPosition = player.transform.position;

        if (drive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if (Input.touchCount > 0)
            {
                finger = Input.GetTouch(0);
                if (finger.phase == TouchPhase.Began)
                {
                    dragging = true;
                    firstPos = finger.position;
                    endPos = finger.position;

                }
            }
            if (dragging)
            {
                if (finger.phase == TouchPhase.Moved)
                {
                    endPos = finger.position;
                }
                if (finger.phase == TouchPhase.Ended)
                {
                    endPos = finger.position;
                    firstPos = finger.position;
                    dragging = false;
                }

                Vector3 temp = (endPos - firstPos).normalized;
                transform.Translate((temp.x) / 10, 0, 0);
                if(temp.x < 0)
                {
                    transform.Rotate(0, 0, .7f);
                }
                else if(temp.x > 0)
                {
                    transform.Rotate(0, 0, -.7f);
                }
                
            }
            
        }
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        drive = false;
        transform.Translate(0, 0, 0);

        camera.transform.position = new Vector3(playerPosition.x + 7 ,playerPosition.y +2  ,playerPosition.z + 1.5f);
        camera.LookAt(player);

        endScene.SetActive(true);
        
    }
        
}   
