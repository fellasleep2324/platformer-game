using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFadeScript : MonoBehaviour
{
    public Animator animator;

    private int leveltoLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToNextLevel();
        }
    }

    public void FadeToNextLevel ()
        {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void FadeToLevel (int levelIndex)
    {
    
        leveltoLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(leveltoLoad);
    }
}
