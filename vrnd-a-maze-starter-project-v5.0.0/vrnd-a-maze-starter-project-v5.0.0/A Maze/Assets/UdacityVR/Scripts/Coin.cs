using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject CoinPoofPrefab;
    public GameObject coin;
    public GameObject CoinCounter;
    int coinCounted;

    void Start()
    {
        coinCounted = 0;
    }

    public void OnCoinClicked()
    {
        //confirm that coin has been clicked
            print("coin has been clicked");

        // Instantiate the CoinPoof Prefab where this coin is located
        Object.Instantiate(CoinPoofPrefab, new Vector3(coin.transform.position.x, coin.transform.position.y, coin.transform.position.z), Quaternion.Euler(-90, 0, 0));
        print("coin populated at " + coin.transform.position.x + "," + coin.transform.position.y + " , " + coin.transform.position.z);
        //needs a action proving its been click #trigger like chest = attach 'trigger event' to game object on PointerClick

        // Make sure the poof animates vertically - done (-90)

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        CoinCounter.GetComponent<CoinCounter>().coinCounted = coinCounted + 1;
        Destroy(coin);
        print ("coins had: " + CoinCounter.GetComponent<CoinCounter>().coinCounted);
    }
}



// Vector3 fwd = transform.TransformDirection(Vector3.forward);

//  if (Input.GetMouseButtonDown (0)) && Physics.Raycast(transform.position, fwd, 10)
//       {
//      print("coin has been clicked");