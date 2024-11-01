using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitScript()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}