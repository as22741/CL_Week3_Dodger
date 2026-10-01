using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
   InputAction upButton;
  InputAction downButton;
  InputAction leftButton;
  InputAction rightButton;
  public Vector3 startPosition;
  
  private AudioSource myCDPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        upButton = InputSystem.actions.FindAction("Up");
        downButton = InputSystem.actions.FindAction("Down");
        leftButton = InputSystem.actions.FindAction("Left");
        rightButton = InputSystem.actions.FindAction("Right");
        
        myCDPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        
        if (playerPosition.x <= -8f)
{
    playerPosition.x = 0f;
}
if (playerPosition.x >= 8f)
{
    playerPosition.x = 0f;
}

if (playerPosition.z <= -20f)
{
    playerPosition.z = 0f;
}
if (playerPosition.z >= 9f)
{
    playerPosition.z = 0f;
}
        if (upButton.IsPressed())
        {
            playerPosition.x += 2 * Time.deltaTime;
        }

        if (downButton.IsPressed())
        {
            playerPosition.x -= 2 * Time.deltaTime;
        }
        
        if (leftButton.IsPressed())
        {
            playerPosition.z += 2 * Time.deltaTime;
        }

        if (rightButton.IsPressed())
        {
            playerPosition.z -= 2 * Time.deltaTime;
        }
        
        transform.position = playerPosition;
    }
    void OnTriggerEnter(Collider other)
    {
        myCDPlayer.Play();
        Debug.Log("touched something");
        transform.position = startPosition;
    }
}
