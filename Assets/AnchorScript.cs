using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorScript : MonoBehaviour
{
    public GameObject RestManager;
    public WorldAnchorManager myWAM;

    // Start is called before the first frame update
    void Start()
    {
        //By using AttachAnchor, existing anchors from the AnchorStore will be loaded
        //Otherwise, they will be created
        myWAM.AttachAnchor(this.gameObject);
    }

    //function used to remove anchor to make the object draggable
    //is called by speech command "move"
    public void MoveIt()
    {
        myWAM.RemoveAnchor(this.gameObject);
        //Set all gameobjects visible to ease placing
        RestManager.GetComponent<GetJSON>().SetVisible();
    }

    //function to set anchor after moving it
    //is called by speech command "anchor"

    public void AnchorIt()
    {
        myWAM.AttachAnchor(this.gameObject);
        RestManager.GetComponent<GetJSON>().SetInvisible();
    }
  
}
