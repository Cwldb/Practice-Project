using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class TitleBtnEvent : MonoBehaviour
{
    public void StartBtnEvent()
    {
        DOTween.KillAll();
        SceneManager.LoadScene("InGameScene"); // or �ε��ϴ� �� ������ �ٲٱ�
    }

    public void ExitBtnEvent()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
