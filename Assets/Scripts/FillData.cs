using TMPro;
using UnityEngine;

public class FillData : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = "Player Name: " + GameManager.Instance.playerName;
    }

}
