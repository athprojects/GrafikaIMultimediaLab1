using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayButton : MonoBehaviour {
    void Start ()
    {
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private static void TaskOnClick()
    {
        SceneManager.LoadScene("scene1");
    }
}
