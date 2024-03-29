using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private bool isTimeDeath = false;
    [SerializeField]
    private string sceneName;
    [SerializeField]
    private float livingTime = 100;


    private void Start()
    {
        if (isTimeDeath)
        {
            StartCoroutine(TimeToDie());
        }
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator TimeToDie()
    {
        Debug.Log("Time is ticking: " + livingTime);
        yield return new WaitForSeconds(livingTime);
        Debug.Log("Time to Die: now!");
        ChangeScene(sceneName);
    }
}
