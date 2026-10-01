using UnityEngine;

public class OrbitBehaviour : MonoBehaviour
{
    public float speed = 4f;
    public float maxDistance;
    public Transform targetPosition;
    public bool movingForward = true;
    private Vector3 startingPos;
    void Start()
    {
        startingPos = transform.position;
    }

    void Update()
    {
        // Calculate how far the asteroid moved from origin along the Z axis
        float currentOffset = transform.position.z - startingPos.z;

        if (movingForward)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
            if (currentOffset >= maxDistance)
            {
                movingForward = false;
            }
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startingPos, speed * Time.deltaTime);
            if (currentOffset <= 0)
            {
                movingForward = true;
            }
        }
    }
}