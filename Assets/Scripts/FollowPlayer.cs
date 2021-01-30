
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; //stores 3 numbers
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
