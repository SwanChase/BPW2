using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomController : MonoBehaviour
{
    public GameObject[] walls;
    public GameObject[] entrances;

    public void UpdateRoom(bool[] status)
    {
        for (int i = 0; i < status.Length; i++)
        {
            entrances[i].SetActive(status[i]);
            walls[i].SetActive(!status[i]);

        }
    }
}
