using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private Transform player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z + player.position.z);
        transform.position = newPosition;
    }


}
