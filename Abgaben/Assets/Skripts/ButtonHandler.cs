using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject player;
    public int zahl=0;
    void Start()
    {
        VirtualButtonBehaviour[] virtualButtons=GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0; i< virtualButtons.Length; i++) {
            zahl++;
            virtualButtons[i].RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)  {

        switch(vb.VirtualButtonName)    {
            case "btnY":
            ++player.GetComponent<SpielerSkript>().moveHorizontal;
                break;
            case "btnX":
                        player.GetComponent<SpielerSkript>().rotateLeft=true;
                break;
            case "btnA":
                        --player.GetComponent<SpielerSkript>().moveHorizontal;
                break;
            case "btnB":
                        player.GetComponent<SpielerSkript>().rotateRight=true;
                break;
        }

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)  {
        switch(vb.VirtualButtonName)    {
            case "btnY":
            --player.GetComponent<SpielerSkript>().moveHorizontal;
                break;
            case "btnX":
                        player.GetComponent<SpielerSkript>().rotateLeft=false;
                break;
            case "btnA":
                        ++player.GetComponent<SpielerSkript>().moveHorizontal;
                break;
            case "btnB":
                        player.GetComponent<SpielerSkript>().rotateRight=false;
                break;
        }
    }
}
