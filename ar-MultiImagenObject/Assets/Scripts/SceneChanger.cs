using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void home()
    {
        SceneManager.LoadScene("Home");
    }

    public void multiimage()
    {
        SceneManager.LoadScene("MultiImage");
    }

    public void multiobject()
    {
        SceneManager.LoadScene("MultiObject");
    }
}
