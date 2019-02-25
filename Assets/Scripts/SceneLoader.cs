using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Slider progressBar;

    private void Awake()
    {
        if (progressBar)
        {
            progressBar.value = 0f;
        }
        
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(AsynchronousLoad(scene));
    }

    IEnumerator AsynchronousLoad(string scene)
    {
        yield return null;

        AsyncOperation ao = SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);

        while (!ao.isDone)
        {
            if (progressBar) { 
                float progress = Mathf.Clamp01(ao.progress / 0.9f);
                progressBar.value = progress;
            }

            yield return null;
        }
    }
}
