using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Positions : MonoBehaviour
{
    public GameObject Shelf1;
    public GameObject Shelf2;
    public GameObject Shelf3;
    public GameObject Shelf4;
    public GameObject Shelf5;
    public GameObject Shelf6;
    public GameObject Shelf7;
    public GameObject Shelf8;
    public GameObject Shelf9;
    public GameObject Shelf10;
    public GameObject Shelf11;
    public GameObject Shelf12;
    public GameObject Shelf13;
    public GameObject Shelf14;
    public GameObject Shelf15;
    public GameObject Shelf16;
    public GameObject Shelf17;
    public GameObject Shelf18;
    public GameObject Shelf19;

    public GameObject WP1;
    public GameObject WP2;
    public GameObject WP3;
    public GameObject WP4;
    public GameObject WP5;
    public GameObject WP6;
    public GameObject WP7;
    public GameObject WP8;
    public GameObject WP9;
    public GameObject WP10;
    public GameObject WP11;
    public GameObject WP12;
    public GameObject WP13;
    public GameObject WP14;
    public GameObject WP15;

    string file;

    // Start is called before the first frame update
    void Start()
    {
        file = @"LocalAppData\\\Positions.json";                              // create file

        using (StreamWriter tw = File.CreateText(file))
        {
            tw.WriteLine("{Start position: x:" + Camera.main.transform.position.x + ",y:" + Camera.main.transform.position.y + ",z:" + Camera.main.transform.position.z + "},rotation: x:" + Camera.main.transform.rotation.x + ",y:" + Camera.main.transform.rotation.y + ",z:" + Camera.main.transform.rotation.z + ",w:" + Camera.main.transform.rotation.w + "}");
            tw.WriteLine("{Shelf1 position: x:" + Shelf1.transform.position.x + ",y:" + Shelf1.transform.position.y + ",z:" + Shelf1.transform.position.z + ",rotation: x:" + Shelf1.transform.rotation.x + ",y:" + Shelf1.transform.rotation.y + ",z:" + Shelf1.transform.rotation.z + ",w:" + Shelf1.transform.rotation.w + "}");
            tw.WriteLine("{Shelf2 position: x:" + Shelf2.transform.position.x + ",y:" + Shelf2.transform.position.y + ",z:" + Shelf2.transform.position.z + ",rotation: x:" + Shelf2.transform.rotation.x + ",y:" + Shelf2.transform.rotation.y + ",z:" + Shelf2.transform.rotation.z + ",w:" + Shelf2.transform.rotation.w + "}");
            tw.WriteLine("{Shelf3 position: x:" + Shelf3.transform.position.x + ",y:" + Shelf3.transform.position.y + ",z:" + Shelf3.transform.position.z + ",rotation: x:" + Shelf3.transform.rotation.x + ",y:" + Shelf3.transform.rotation.y + ",z:" + Shelf3.transform.rotation.z + ",w:" + Shelf3.transform.rotation.w + "}");
            tw.WriteLine("{Shelf4 position: x:" + Shelf4.transform.position.x + ",y:" + Shelf4.transform.position.y + ",z:" + Shelf4.transform.position.z + ",rotation: x:" + Shelf4.transform.rotation.x + ",y:" + Shelf4.transform.rotation.y + ",z:" + Shelf4.transform.rotation.z + ",w:" + Shelf4.transform.rotation.w + "}");
            tw.WriteLine("{Shelf5 position: x:" + Shelf5.transform.position.x + ",y:" + Shelf5.transform.position.y + ",z:" + Shelf5.transform.position.z + ",rotation: x:" + Shelf5.transform.rotation.x + ",y:" + Shelf5.transform.rotation.y + ",z:" + Shelf5.transform.rotation.z + ",w:" + Shelf5.transform.rotation.w + "}");
            tw.WriteLine("{Shelf6 position: x:" + Shelf6.transform.position.x + ",y:" + Shelf6.transform.position.y + ",z:" + Shelf6.transform.position.z + ",rotation: x:" + Shelf6.transform.rotation.x + ",y:" + Shelf6.transform.rotation.y + ",z:" + Shelf6.transform.rotation.z + ",w:" + Shelf6.transform.rotation.w + "}");
            tw.WriteLine("{Shelf7 position: x:" + Shelf7.transform.position.x + ",y:" + Shelf7.transform.position.y + ",z:" + Shelf7.transform.position.z + ",rotation: x:" + Shelf7.transform.rotation.x + ",y:" + Shelf7.transform.rotation.y + ",z:" + Shelf7.transform.rotation.z + ",w:" + Shelf7.transform.rotation.w + "}");
            tw.WriteLine("{Shelf8 position: x:" + Shelf8.transform.position.x + ",y:" + Shelf8.transform.position.y + ",z:" + Shelf8.transform.position.z + ",rotation: x:" + Shelf8.transform.rotation.x + ",y:" + Shelf8.transform.rotation.y + ",z:" + Shelf8.transform.rotation.z + ",w:" + Shelf8.transform.rotation.w + "}");
            tw.WriteLine("{Shelf9 position: x:" + Shelf9.transform.position.x + ",y:" + Shelf9.transform.position.y + ",z:" + Shelf9.transform.position.z + ",rotation: x:" + Shelf9.transform.rotation.x + ",y:" + Shelf9.transform.rotation.y + ",z:" + Shelf9.transform.rotation.z + ",w:" + Shelf9.transform.rotation.w + "}");
            tw.WriteLine("{Shelf10 position: x:" + Shelf10.transform.position.x + ",y:" + Shelf10.transform.position.y + ",z:" + Shelf10.transform.position.z + ",rotation: x:" + Shelf10.transform.rotation.x + ",y:" + Shelf10.transform.rotation.y + ",z:" + Shelf10.transform.rotation.z + ",w:" + Shelf10.transform.rotation.w + "}");
            tw.WriteLine("{Shelf11 position: x:" + Shelf11.transform.position.x + ",y:" + Shelf11.transform.position.y + ",z:" + Shelf11.transform.position.z + ",rotation: x:" + Shelf11.transform.rotation.x + ",y:" + Shelf11.transform.rotation.y + ",z:" + Shelf11.transform.rotation.z + ",w:" + Shelf11.transform.rotation.w + "}");
            tw.WriteLine("{Shelf12 position: x:" + Shelf12.transform.position.x + ",y:" + Shelf12.transform.position.y + ",z:" + Shelf12.transform.position.z + ",rotation: x:" + Shelf12.transform.rotation.x + ",y:" + Shelf12.transform.rotation.y + ",z:" + Shelf12.transform.rotation.z + ",w:" + Shelf12.transform.rotation.w + "}");
            tw.WriteLine("{Shelf13 position: x:" + Shelf13.transform.position.x + ",y:" + Shelf13.transform.position.y + ",z:" + Shelf13.transform.position.z + ",rotation: x:" + Shelf13.transform.rotation.x + ",y:" + Shelf13.transform.rotation.y + ",z:" + Shelf13.transform.rotation.z + ",w:" + Shelf13.transform.rotation.w + "}");
            tw.WriteLine("{Shelf14 position: x:" + Shelf14.transform.position.x + ",y:" + Shelf14.transform.position.y + ",z:" + Shelf14.transform.position.z + ",rotation: x:" + Shelf14.transform.rotation.x + ",y:" + Shelf14.transform.rotation.y + ",z:" + Shelf14.transform.rotation.z + ",w:" + Shelf14.transform.rotation.w + "}");
            tw.WriteLine("{Shelf15 position: x:" + Shelf15.transform.position.x + ",y:" + Shelf15.transform.position.y + ",z:" + Shelf15.transform.position.z + ",rotation: x:" + Shelf15.transform.rotation.x + ",y:" + Shelf15.transform.rotation.y + ",z:" + Shelf15.transform.rotation.z + ",w:" + Shelf15.transform.rotation.w + "}");
            tw.WriteLine("{Shelf16 position: x:" + Shelf16.transform.position.x + ",y:" + Shelf16.transform.position.y + ",z:" + Shelf16.transform.position.z + ",rotation: x:" + Shelf16.transform.rotation.x + ",y:" + Shelf16.transform.rotation.y + ",z:" + Shelf16.transform.rotation.z + ",w:" + Shelf16.transform.rotation.w + "}");
            tw.WriteLine("{Shelf17 position: x:" + Shelf17.transform.position.x + ",y:" + Shelf17.transform.position.y + ",z:" + Shelf17.transform.position.z + ",rotation: x:" + Shelf17.transform.rotation.x + ",y:" + Shelf17.transform.rotation.y + ",z:" + Shelf17.transform.rotation.z + ",w:" + Shelf17.transform.rotation.w + "}");
            tw.WriteLine("{Shelf18 position: x:" + Shelf18.transform.position.x + ",y:" + Shelf18.transform.position.y + ",z:" + Shelf18.transform.position.z + ",rotation: x:" + Shelf18.transform.rotation.x + ",y:" + Shelf18.transform.rotation.y + ",z:" + Shelf18.transform.rotation.z + ",w:" + Shelf18.transform.rotation.w + "}");
            tw.WriteLine("{Shelf19 position: x:" + Shelf19.transform.position.x + ",y:" + Shelf19.transform.position.y + ",z:" + Shelf19.transform.position.z + ",rotation: x:" + Shelf19.transform.rotation.x + ",y:" + Shelf19.transform.rotation.y + ",z:" + Shelf19.transform.rotation.z + ",w:" + Shelf19.transform.rotation.w + "}");
            tw.Flush();
            tw.WriteLine("{WP1 position: x:" + WP1.transform.position.x + ",y:" + WP1.transform.position.y + ",z:" + WP1.transform.position.z + ",rotation: x:" + WP1.transform.rotation.x + ",y:" + WP1.transform.rotation.y + ",z:" + WP1.transform.rotation.z + ",w:" + WP1.transform.rotation.w + "}");
            tw.WriteLine("{WP2 position: x:" + WP2.transform.position.x + ",y:" + WP2.transform.position.y + ",z:" + WP2.transform.position.z + ",rotation: x:" + WP2.transform.rotation.x + ",y:" + WP2.transform.rotation.y + ",z:" + WP2.transform.rotation.z + ",w:" + WP2.transform.rotation.w + "}");
            tw.WriteLine("{WP3 position: x:" + WP3.transform.position.x + ",y:" + WP3.transform.position.y + ",z:" + WP3.transform.position.z + ",rotation: x:" + WP3.transform.rotation.x + ",y:" + WP3.transform.rotation.y + ",z:" + WP3.transform.rotation.z + ",w:" + WP3.transform.rotation.w + "}");
            tw.WriteLine("{WP4 position: x:" + WP4.transform.position.x + ",y:" + WP4.transform.position.y + ",z:" + WP4.transform.position.z + ",rotation: x:" + WP4.transform.rotation.x + ",y:" + WP4.transform.rotation.y + ",z:" + WP4.transform.rotation.z + ",w:" + WP4.transform.rotation.w + "}");
            tw.WriteLine("{WP5 position: x:" + WP5.transform.position.x + ",y:" + WP5.transform.position.y + ",z:" + WP5.transform.position.z + ",rotation: x:" + WP5.transform.rotation.x + ",y:" + WP5.transform.rotation.y + ",z:" + WP5.transform.rotation.z + ",w:" + WP5.transform.rotation.w + "}");
            tw.WriteLine("{WP6 position: x:" + WP6.transform.position.x + ",y:" + WP6.transform.position.y + ",z:" + WP6.transform.position.z + ",rotation: x:" + WP6.transform.rotation.x + ",y:" + WP6.transform.rotation.y + ",z:" + WP6.transform.rotation.z + ",w:" + WP6.transform.rotation.w + "}");
            tw.WriteLine("{WP7 position: x:" + WP7.transform.position.x + ",y:" + WP7.transform.position.y + ",z:" + WP7.transform.position.z + ",rotation: x:" + WP7.transform.rotation.x + ",y:" + WP7.transform.rotation.y + ",z:" + WP7.transform.rotation.z + ",w:" + WP7.transform.rotation.w + "}");
            tw.WriteLine("{WP8 position: x:" + WP8.transform.position.x + ",y:" + WP8.transform.position.y + ",z:" + WP8.transform.position.z + ",rotation: x:" + WP8.transform.rotation.x + ",y:" + WP8.transform.rotation.y + ",z:" + WP8.transform.rotation.z + ",w:" + WP8.transform.rotation.w + "}");
            tw.WriteLine("{WP9 position: x:" + WP9.transform.position.x + ",y:" + WP9.transform.position.y + ",z:" + WP9.transform.position.z + ",rotation: x:" + WP9.transform.rotation.x + ",y:" + WP9.transform.rotation.y + ",z:" + WP9.transform.rotation.z + ",w:" + WP9.transform.rotation.w + "}");
            tw.WriteLine("{WP10 position: x:" + WP10.transform.position.x + ",y:" + WP10.transform.position.y + ",z:" + WP10.transform.position.z + ",rotation: x:" + WP10.transform.rotation.x + ",y:" + WP10.transform.rotation.y + ",z:" + WP10.transform.rotation.z + ",w:" + WP10.transform.rotation.w + "}");
            tw.WriteLine("{WP11 position: x:" + WP11.transform.position.x + ",y:" + WP11.transform.position.y + ",z:" + WP11.transform.position.z + ",rotation: x:" + WP11.transform.rotation.x + ",y:" + WP11.transform.rotation.y + ",z:" + WP11.transform.rotation.z + ",w:" + WP11.transform.rotation.w + "}");
            tw.WriteLine("{WP12 position: x:" + WP12.transform.position.x + ",y:" + WP12.transform.position.y + ",z:" + WP12.transform.position.z + ",rotation: x:" + WP12.transform.rotation.x + ",y:" + WP12.transform.rotation.y + ",z:" + WP12.transform.rotation.z + ",w:" + WP12.transform.rotation.w + "}");
            tw.WriteLine("{WP13 position: x:" + WP13.transform.position.x + ",y:" + WP13.transform.position.y + ",z:" + WP13.transform.position.z + ",rotation: x:" + WP13.transform.rotation.x + ",y:" + WP13.transform.rotation.y + ",z:" + WP13.transform.rotation.z + ",w:" + WP13.transform.rotation.w + "}");
            tw.WriteLine("{WP14 position: x:" + WP14.transform.position.x + ",y:" + WP14.transform.position.y + ",z:" + WP14.transform.position.z + ",rotation: x:" + WP14.transform.rotation.x + ",y:" + WP14.transform.rotation.y + ",z:" + WP14.transform.rotation.z + ",w:" + WP14.transform.rotation.w + "}");
            tw.WriteLine("{WP15 position: x:" + WP15.transform.position.x + ",y:" + WP15.transform.position.y + ",z:" + WP15.transform.position.z + ",rotation: x:" + WP15.transform.rotation.x + ",y:" + WP15.transform.rotation.y + ",z:" + WP15.transform.rotation.z + ",w:" + WP15.transform.rotation.w + "}");
            tw.Flush();
        }

    }

}
