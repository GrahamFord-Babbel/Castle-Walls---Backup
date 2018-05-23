using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject KeyPoofPrefab;
    public Door door;
    public GameObject key;
    public bool hasKey = false;

    void Update()
    {
        //Not required, but for fun why not try adding a Key Floating Animation here :)

    }

    public void OnKeyClicked()
    {
        // Instatiate the KeyPoof Prefab where this key is located
        Object.Instantiate(KeyPoofPrefab, new Vector3(key.transform.position.x, key.transform.position.y, key.transform.position.z), Quaternion.Euler(-90, 0, 0));
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(key);
        door.GetComponent<Door>().hasKey = true;
        door.Unlock();
    }
}