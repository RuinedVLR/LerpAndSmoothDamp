using UnityEngine;

public class Vectors : MonoBehaviour
{
    public float timer = 0f;
    public GameObject cube1;
    public GameObject cube2;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 positionA = new Vector3(cube1.transform.position.x, cube1.transform.position.y, cube1.transform.position.z);
        Vector3 positionB = new Vector3(cube2.transform.position.x, cube2.transform.position.y, cube2.transform.position.z);


        timer += Time.deltaTime;

        transform.position = Vector3.Lerp(positionA, positionB, timer);

        if (timer >= 1f)
        {
            transform.position = positionA;
            timer = 0f;
        }
    }
}
