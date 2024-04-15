using System.Collections;

using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Clicker()
    {
        Debug.Log("Loading 1");
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
