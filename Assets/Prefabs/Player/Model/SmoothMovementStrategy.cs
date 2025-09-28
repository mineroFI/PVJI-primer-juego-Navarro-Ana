using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    public void Move(Transform transform, Player player)
    {
        float moveX = Input.GetAxis("Horizontal") * player.velocity * Time.deltaTime;
        transform.Translate(moveX, 0, 0);
    }
}