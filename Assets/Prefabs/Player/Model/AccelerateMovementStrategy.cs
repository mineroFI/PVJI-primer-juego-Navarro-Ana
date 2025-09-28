using UnityEngine;

public class AccelerateMovementStrategy : IMovementStrategy
{
    private float currentSpeed = 0f;

    public void Move(Transform transform, Player player)
    {
        float inputX = Input.GetAxis("Horizontal");
        currentSpeed = Mathf.Clamp(currentSpeed + inputX * player.acceleration * Time.deltaTime, -player.velocity, player.velocity);
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }
}