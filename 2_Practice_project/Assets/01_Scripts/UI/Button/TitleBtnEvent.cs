using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class TitleBtnEvent : MonoBehaviour
{
    public void StartBtnEvent()
    {
        DOTween.KillAll();
        SceneManager.LoadScene("InGameScene"); // or 로딩하는 씬 있으면 바꾸기
    }

    public void ExitBtnEvent()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
