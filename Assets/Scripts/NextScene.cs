using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public TMP_InputField inputField;

    public void ToNextScene()
    {

        GameManager.Instance.playerName = inputField.text.ToString();

        SceneManager.LoadScene(1);
    }
}
