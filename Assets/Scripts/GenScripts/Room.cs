using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public int Width;
    public int Height;
    public int X;
    public int Y;

    // Start is called before the first frame update
    void Start()
    {
        if (RoomController.Instance == null)
        {
            Debug.Log("Dafug u doin in the wrong scene");
            return;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(Width, Height, 0));
    }

    public Vector3 GetRoomCenter()
    {
        return new Vector3(X * Width, Y * Height);
    }
}
