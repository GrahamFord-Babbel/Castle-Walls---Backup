using UnityEngine;

public class TestCollision : MonoBehaviour
{

    void FixedUpdate()
    {
        RaycastHit hit;

        Debug.DrawLine(transform.position, transform.forward * 100);
        if (Input.GetKeyDown(KeyCode.Alpha0) && Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}