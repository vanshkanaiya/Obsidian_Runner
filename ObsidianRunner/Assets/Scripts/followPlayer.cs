using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void LateUpdate()
    {
        if (player == null) return;

        transform.position = new Vector3(
            player.position.x + offset.x,
            player.position.y + offset.y,
            -10f   
        );
    }
}
