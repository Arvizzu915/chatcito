using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ServerItem : MonoBehaviour
{
    public Button joinButton;
    public TextMeshProUGUI nameLabel;
    public TextMeshProUGUI ipLabel;
    private string address = string.Empty;

    public void  SetServerLabel(string nameText, string ipText)
    {
        nameLabel.text = nameText;
        ipLabel.text = ipText;
    }

    public Button GetJoinButton()
    {
        return joinButton;
    }
}
