using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToLoad;
    public int requiredClicks = 6;
    private int clickCount = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            {
                clickCount++;
                if (clickCount > requiredClicks)
                {
                    SceneManager.LoadScene(sceneToLoad);
                }
            }
        }
    }
}