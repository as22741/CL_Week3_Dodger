using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    public Transform targetPosition;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, 4 * Time.deltaTime);
        Vector3 asteroidPosition = transform.position;
        
        if (asteroidPosition.x <= -8f) //initially i had just written the exact coordinates but it was very inefficient, defining a separate start position was easier
        {
            transform.position = startPosition;
        }
        if (asteroidPosition.x >= 8f)
        {
            transform.position = startPosition;
        }

        if (asteroidPosition.z <= -20f)
        {
            transform.position = startPosition;
        }

        if (asteroidPosition.z >= 9f)
        {
            transform.position = startPosition;
        }
        
    }
}
