using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartSceneManage : MonoBehaviour
{
    public GameObject m_StartPanel;
    public void OnStartEvent()
    {
        SceneManager.LoadScene("Level 1");
        GameManager.ResetScore();
    }
    public void OnExitEvent()
    {
        Application.Quit();
    }
}