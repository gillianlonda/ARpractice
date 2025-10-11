using UnityEngine;

using TMPro;
public class Buttonscript : MonoBehaviour
{
    public TMP_Text text;

    void Start()
    {

    }

    private void Update()
    {
        
    }

    public void ClickButton()
    {
        text.text = "Selected";
    }
}
