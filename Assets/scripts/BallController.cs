using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float impulseForce = 3f;

    private bool ignoreNextcollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (ignoreNextcollision)
        {
            return;
        }
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(Vector3.up*impulseForce, ForceMode.Impulse);
        Invoke ("AllNextCollision", 0.2f);
    }
    private void AllowNextCollision()
    {
        ignoreNextcollision = false;
    }
}
