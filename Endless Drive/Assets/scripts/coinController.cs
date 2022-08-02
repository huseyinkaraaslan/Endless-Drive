using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinController : MonoBehaviour
{
    public GameObject coin,target,catchCoins;
    public int coinPoint = 0;
    Vector3 lerpDistance;



    // Start is called before the first frame update
    void Start()
    {
        lerpDistance = new Vector3(-3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        coin.transform.Rotate(2, 0, 0);
        catchCoins.transform.position = Vector3.Lerp(catchCoins.transform.position, target.transform.position - lerpDistance, .1f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "coin":
                increaseCoin();

                if (coin.transform.position.z == 3)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, -.5f);
                }
                else if (coin.transform.position.z == -.5f)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, -4f);
                }
                else if (coin.transform.position.z == -4f)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, 3f);
                }
                else if(coin.transform.position.z == 1.5f)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, -2f);
                }
                else if(coin.transform.position.z == -2f)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, 1.5f);
                }
                break;

            case "catchCoins":
                
                if (coin.transform.position.z == 3)
                {
                    coin.transform.position -= new Vector3(90, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, -.5f);
                }
                else if (coin.transform.position.z == -.5f)
                {
                    coin.transform.position -= new Vector3(90, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, -4f);
                }
                else if (coin.transform.position.z == -4f)
                {
                    coin.transform.position -= new Vector3(90, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, 3f);
                }
                else if (coin.transform.position.z == 1.5f)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, -2f);
                }
                else if (coin.transform.position.z == -2f)
                {
                    coin.transform.position -= new Vector3(80, 0, 0);
                    coin.transform.position = new Vector3(coin.transform.position.x, coin.transform.position.y, 1.5f);
                }
                break;
        }
        
    }

    public void increaseCoin()
    {
        coinPoint += 10;
        PlayerPrefs.SetInt(nameof(coinPoint), coinPoint);
    }
}
