using System.Threading;
using UnityEngine;

public class SmoothDamp : MonoBehaviour
{
    public float smoothTime = 0.2f;
    public GameObject cube1;
    public GameObject cube2;
    public Vector3 velocity = new Vector3(-10, 0, 0);

    // Update is called once per frame
    void Update()
    {
        Vector3 positionA = new Vector3(cube1.transform.position.x, cube1.transform.position.y, cube1.transform.position.z);
        Vector3 positionB = new Vector3(cube2.transform.position.x, cube2.transform.position.y, cube2.transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, positionB, ref velocity, smoothTime);

        if (Vector3.Distance(transform.position, positionB) <= 0.1f)
        {
            transform.position = positionA;
        }
    }
}
