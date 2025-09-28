using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    private IMovementStrategy movementStrategy;
    private Player player;

    private void Start()
    {
        
        forceToApply = new Vector3(0, 0, 300);
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Apply force every 2 seconds

        
        player = new Player();
        player.velocity = 5f;  
        player.acceleration = 10f;  

        
        movementStrategy = new AccelerateMovementStrategy();  
    }

    private void Update()
    {
        // Llama al movimiento lateral constantemente
        MovePlayer();
    }

    private void FixedUpdate()
    {
        
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }
    }

    public void MovePlayer()
    {
        movementStrategy.Move(transform, player);
    }
}