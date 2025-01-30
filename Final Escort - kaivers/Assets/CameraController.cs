using UnityEngine;

public class CameraController : MonoBehaviour
{

public Transform player;
private Transform trans; 

private int offset_x = -8;
private int offset_z = -8;
private int offset_y = 10;

    void Start(){
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        trans.position = new Vector3(player.transform.position.x + offset_x, offset_y , player.transform.position.z + offset_z);
    }
}
