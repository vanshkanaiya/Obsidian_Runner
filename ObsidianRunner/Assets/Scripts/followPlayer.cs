using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //public Vector3 offset;

    private void OnEnable()
    {
        StaticVars.PlayerSpawn += OnPlayerSpawn;
    }

    private void OnDisable()
    {
        StaticVars.PlayerSpawn -= OnPlayerSpawn;
    }

    void OnPlayerSpawn(Transform t)
    {
        player = t;
    }

    //void LateUpdate()
    //{
    //    if (player == null) return;

    //    transform.position = new Vector3(
    //        player.position.x + offset.x,
    //        player.position.y + offset.y,
    //        -10f   
    //    );
    //}
    //public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (player == null) 
            return;

        Vector3 targetPosition = player.position;
        targetPosition.z = -10f;
        transform.position = targetPosition;

        //transform.position = Vector3.Lerp(
        //    transform.position,
        //    targetPosition,
        //    smoothSpeed * Time.deltaTime
        //);

    }
}
