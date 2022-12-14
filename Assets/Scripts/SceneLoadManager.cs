using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    //Variables
    [SerializeField] private float transitionTime = 1f;

    private Animator transitionAnimator;
    // Start is called before the first frame update
    void Start()
    {
        transitionAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       /*if (Input.anyKeyDown)
        {
            LoadNextScene();
        }*/
    }

    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextSceneIndex));
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        //Dispara el trigger para reproducir la animación FadeIn
        //Espera 1.0s
        transitionAnimator.SetTrigger("StartTransition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
