using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {

        forceToApply = new Vector3(0, 0, 300);
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Apply force every 2 seconds

    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        timeSinceLastForce += Time.fixedDeltaTime;
        if(timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }

    }
}
