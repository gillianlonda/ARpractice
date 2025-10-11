using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject buttonB; // Drag Button B here in the Inspector
    public GameObject buttonC;
    public GameObject buttonD;
    // This method will be called when Button A is clicked
    public void ShowButtonB()
    {
        if (buttonB != null)
        {
            buttonB.SetActive(true); // Make Button B visible
        }
    }
    public void ShowButtonC()
    {
        if (buttonC != null)
        {
            buttonC.SetActive(true); // Make Button B visible
        }
    }
    public void ShowButtonD()
    {
        if (buttonD != null)
        {
            buttonD.SetActive(true); // Make Button B visible
        }
    }
}
