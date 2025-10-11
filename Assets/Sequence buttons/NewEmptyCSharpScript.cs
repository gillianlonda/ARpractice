using UnityEngine;

public class ButtonHandle : MonoBehaviour
{
    public GameObject buttonB; // Drag Button B here in the Inspector
    public GameObject buttonC;
    public GameObject buttonD;
    public GameObject buttonA;
    // This method will be called when Button A is clicked
    public void ShowButtonB()
    {
        if (buttonB != null)
        {
            buttonB.SetActive(true); // Make Button B visible
        if (buttonA != null)
            buttonA.SetActive(false);
        }
    }
    public void ShowButtonC()
    {
        if (buttonC != null)
        {
            buttonC.SetActive(true); // Make Button B visible
        if (buttonA != null)
            buttonA.SetActive(false);
        }
    }
    public void ShowButtonD()
    {
        if (buttonD != null)
        {
            buttonD.SetActive(true); // Make Button B visible
        if (buttonA != null)
            buttonA.SetActive(false);
        }
    }

}
