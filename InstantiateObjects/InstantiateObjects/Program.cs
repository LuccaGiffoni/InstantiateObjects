using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

// Rename it as you need
public class InstantiateObjects : MonoBehaviour
{
    // Creating a GameObject to your prefab
    public GameObject prefab;

    // List that holds all created objects, could deleate all instances if you want to
    public List<GameObject> createdObjects = new List<GameObject>();

    private float minX, maxX, minY, maxY;

    void Start()
    {
        // Get the screen bounds
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;
    }

    public void Instantiate()
    {
        // a prefab is need to perform the instantiation
        if (prefab != null)
        {
            // get a random postion to instantiate the prefab - you can change this to be created at a fied point if desired
            Vector3 position = new Vector3(0, -1 / 2, 1);

            // instantiate the object
            GameObject go = (GameObject)Instantiate(prefab, position, Quaternion.identity);
            createdObjects.Add(go);
        }
    }
}
