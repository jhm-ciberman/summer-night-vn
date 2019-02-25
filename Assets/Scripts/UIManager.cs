using UnityEngine;
using Fungus;

public class UIManager: MonoBehaviour {

    public NarrativeLogMenu narrativeLogMenu;

    public SayDialog sayDialog;

    private CanvasGroup narrativeLogCanvasGroup;

    private void Awake()
    {
        narrativeLogMenu.Hide(true);
    }

    public void HideAllUI()
    {
        sayDialog.ForceHide();
        narrativeLogMenu.Hide();
    }

    public void ShowNarrativeLog()
    {
        narrativeLogMenu.Show();
        sayDialog.ForceHide();
    }

    public void ShowSayDialog()
    {
        sayDialog.ForceShow();
        narrativeLogMenu.Hide();
    }

    public void HandleClickOnScreen()
    {
        if (sayDialog.IsForcedToHide)
        {
            ShowSayDialog();
        }
        else
        {
            sayDialog.GetComponent<Writer>().OnNextLineEvent();
        }
    }
}
