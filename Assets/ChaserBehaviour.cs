using UnityEngine;

public class ChaserBehaviour : MonoBehaviour
{
    public float speed;         // How fast the object follows
    public float aggroDistance; // How close it gets before stopping
    public Transform targetPosition;
    private Vector3 startPosition;
    private bool escape = false;
//range parameters
    // public float minX = -8f;
    // public float maxX = 8f;
    // public float minY = 0.2f; //top down game so almost 0
    // public float maxY = 0.35f; 
    // public float minZ = -20f;
    // public float maxZ = 9f; //not required
    
    
    void Start()
    {
        startPosition = transform.position;
        RandomizePosition();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, targetPosition.position);

        if (distanceToPlayer < aggroDistance)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
            escape = true;
        }

        if (distanceToPlayer > aggroDistance && escape == true)
        {
            RandomizePosition();
            escape = false;
        }
    }

    void RandomizePosition()
        {
            float randomX = Random.Range(-8f, 8f); //there definitely has to be an easier way of doing this but it is 3am and I cannot think
            float randomY = Random.Range(0.25f, 0.35f);
            float randomZ = Random.Range(-20f, 9f);
            
            transform.position = new Vector3(randomX, randomY, randomZ);
        }
}