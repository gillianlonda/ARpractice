using UnityEngine;

public class BUTTONHANDLE : MonoBehaviour
{
    public GameObject buttonB; // Drag Button B here in the Inspector
    public GameObject buttonC;
    public GameObject buttonD;
    public GameObject buttonA;

    // This method will be called when Button A is clicked to show Button B
    public void ShowButtonB()
    {
        if (buttonB != null) buttonB.SetActive(false);  
        {
            buttonB.SetActive(true); // Make Button B visible
            if (buttonA != null)
                buttonA.SetActive(false);
        }
    }

    // This method will be called when Button A is clicked to show Button C
    public void ShowButtonC()
    {
        if (buttonC != null)
        {
            buttonC.SetActive(true); // Make Button C visible
            if (buttonA != null)
                buttonA.SetActive(false);
        }
    }

    // This method will be called when Button A is clicked to show Button D
    public void ShowButtonD()
    {
        if (buttonD != null)
        {
            buttonD.SetActive(true); // Make Button D visible
            if (buttonA != null)
                buttonA.SetActive(false);
        }
    }
}
