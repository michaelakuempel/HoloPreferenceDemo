using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Threading;


public class NEEMLogging : MonoBehaviour
{
    LocationInfo location;
    string tffile = "";         // variable for tf file name
    string fileName = "";       // varibla for triples file name
    float ts;             // variable for new timestamp
    string EpisodeName = "";    // variable for EpisodeName
    string Agent = "";          // variable for Agent individual name
    float starttime;      // variable to start action specific start time
    float endtime;        // variable to store action specific end time
    string timename = "";       // variable for time individuals
    string Taptsk = "";
    int tries = 0;              // variable is used to identify first action (surveying)
    public GameObject anchor;
    public GameObject anchor2;

    



    // Start is called before the first frame update
    void Start()
    {

        string filestring = CreateRandomString();                               // Create random string for naming of both log files
        fileName = @"LocalAppData\\\HoloLensPreferenceDemo_" + filestring + "_triples.json";    // Create name of triples file
        tffile = @"LocalAppData\\\HololensPD_" + filestring + "_tf.json";                              // Create matching name for tf file
        EpisodeName = CreateRandomString();                                     // Create random episode name
        ts = Time.time;                                                         // Get timestamp as string
        starttime = ts;                                                         // save timestamp as start time


        //write triples file via Steamreader
       

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode_" + EpisodeName + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode\",\"graph\":\"user\"}");
                sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode_" + EpisodeName + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\",\"graph\":\"user\"}");
                sw.Flush();
            }

        //System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();

        System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US");
        System.Globalization.CultureInfo myCI = (System.Globalization.CultureInfo)customCulture.Clone();
   
        myCI.NumberFormat.NumberDecimalSeparator = ".";
        //System.Threading.Thread.CurrentThread.CurrentCulture = myCI;
        System.Globalization.CultureInfo.CurrentCulture = myCI;

        DateTime dt = DateTime.Now;
        //write tf file via Steamreader

        using (StreamWriter tw = File.CreateText(tffile))
            {
                tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"HoloLens\",\"transform\":{\"translation\":{\"x\":" + Camera.main.transform.position.x + ",\"y\":" + Camera.main.transform.position.y + ",\"z\":" + Camera.main.transform.position.z + "},\"rotation\":{\"x\":" + Camera.main.transform.rotation.x + ",\"y\":" + Camera.main.transform.rotation.y + ",\"z\":" + Camera.main.transform.rotation.z + ",\"w\":" + Camera.main.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
                tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"Shelf19\",\"transform\":{\"translation\":{\"x\":" + anchor.transform.position.x + ",\"y\":" + anchor.transform.position.y + ",\"z\":" + anchor.transform.position.z + "},\"rotation\":{\"x\":" + anchor.transform.rotation.x + ",\"y\":" + anchor.transform.rotation.y + ",\"z\":" + anchor.transform.rotation.z + ",\"w\":" + anchor.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
                tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"Shelf18\",\"transform\":{\"translation\":{\"x\":" + anchor2.transform.position.x + ",\"y\":" + anchor2.transform.position.y + ",\"z\":" + anchor2.transform.position.z + "},\"rotation\":{\"x\":" + anchor2.transform.rotation.x + ",\"y\":" + anchor2.transform.rotation.y + ",\"z\":" + anchor2.transform.rotation.z + ",\"w\":" + anchor2.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
                tw.Flush();
            }
        
    }

    //Function to get the current timestamp
    /*private string GetTime()
    {
        DateTime date = DateTime.ParseExact(DateTime.Now.ToString(), "dd/MM/yyyy H:mm:ss", null);
        Double timestamp = Math.Truncate((date.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
        ts = timestamp.ToString();
        return ts;
    }*/

    //Function to create random string with 6 uppercase letters for naming individuals
    private string CreateRandomString(int stringLength = 5)
    {
        string randomString = "";
        string[] characters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        for (int i = 0; i <= stringLength; i++)
        {
            randomString = randomString + characters[UnityEngine.Random.Range(0, characters.Length)];
        }
        return randomString;
    }

    //OnMouseDown is being called when user selects a preference in menu
    public void OnClick()
    {
        
        // Write tf file via Steamreader
        DateTime dt = DateTime.Now;

        using (StreamWriter tw = File.AppendText(tffile))
        {
            tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"HoloLens\",\"transform\":{\"translation\":{\"x\":" + Camera.main.transform.position.x + ",\"y\":" + Camera.main.transform.position.y + ",\"z\":" + Camera.main.transform.position.z + "},\"rotation\":{\"x\":" + Camera.main.transform.rotation.x + ",\"y\":" + Camera.main.transform.rotation.y + ",\"z\":" + Camera.main.transform.rotation.z + ",\"w\":" + Camera.main.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
            tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"" + this.gameObject.transform.name + "\",\"transform\":{\"translation\":{\"x\":" + this.gameObject.transform.position.x + ",\"y\":" + this.gameObject.transform.position.y + ",\"z\":" + this.gameObject.transform.position.z + "},\"rotation\":{\"x\":" + this.gameObject.transform.rotation.x + ",\"y\":" + this.gameObject.transform.rotation.y + ",\"z\":" + this.gameObject.transform.rotation.z + ",\"w\":" + this.gameObject.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
            tw.Flush();
        }

        string LookAt = CreateRandomString();       // create name for looking at action
        string LookAtTsk = CreateRandomString();    // create name for looking at task
        timename = CreateRandomString();
        string objname = CreateRandomString();
        string infobj = CreateRandomString();

        ts = Time.time;


        //log Looking At action that was privously performed

        using (StreamWriter sw = File.AppendText(fileName))
        {
            endtime = ts;                                   //starttime was saved earlier
            timename = CreateRandomString();
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode_" + EpisodeName + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalBegin\",\"o\":{\"$numberDecimal\": \"" + starttime + "\"}},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalEnd\",\"o\":{\"$numberDecimal\": \"" + endtime + "\"}},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingAt_" + LookAtTsk + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#isPerformedBy\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson_" + Agent + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasParticipant\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingAt_" + LookAtTsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingAt\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingAt_" + LookAtTsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingAt_" + LookAtTsk + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#defines\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookAt + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesRole\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject_" + infobj + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject_" + infobj + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject_" + infobj + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#DigitalObject\"},");


            starttime = endtime;
            ts = Time.time;
            endtime = ts;                                   //starttime was saved earlier
            timename = CreateRandomString();
            string Tapact = CreateRandomString();
            Taptsk = CreateRandomString();
            string AltName = CreateRandomString();

            //now also log selection action
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode_" + EpisodeName + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\",\"graph\":\"user\"}");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalBegin\",\"o\":{\"$numberDecimal\": \"" + starttime + "\"}},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalEnd\",\"o\":{\"$numberDecimal\": \"" + endtime + "\"}},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#isPerformedBy\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson_" + Agent + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasParticipant\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask\",\"o\":\"http://www.ease-crc.org/ont/EASE-OBJ.owl#Tapping_" + Taptsk + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Tapping_" + Taptsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Tapping\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Tapping_" + Taptsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Tapping_" + Taptsk + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#starts\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Alteration_" + AltName + "\"},");
            sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + Tapact + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesRole\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Alteration_" + AltName + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Alteration_" + AltName + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Alteration\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Alteration_" + AltName + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
            sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Alteration_" + AltName + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#associatedWith\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + objname + "\"},");
            sw.Flush();
        }

        // Write tf file via Steamreader
        dt = DateTime.Now;

        using (StreamWriter tw = File.AppendText(tffile))
        {
            tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"HoloLens\",\"transform\":{\"translation\":{\"x\":" + Camera.main.transform.position.x + ",\"y\":" + Camera.main.transform.position.y + ",\"z\":" + Camera.main.transform.position.z + "},\"rotation\":{\"x\":" + Camera.main.transform.rotation.x + ",\"y\":" + Camera.main.transform.rotation.y + ",\"z\":" + Camera.main.transform.rotation.z + ",\"w\":" + Camera.main.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
            tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"Menu\",\"transform\":{\"translation\":{\"x\":" + this.gameObject.transform.position.x + ",\"y\":" + this.gameObject.transform.position.y + ",\"z\":" + this.gameObject.transform.position.z + "},\"rotation\":{\"x\":" + this.gameObject.transform.rotation.x + ",\"y\":" + this.gameObject.transform.rotation.y + ",\"z\":" + this.gameObject.transform.rotation.z + ",\"w\":" + this.gameObject.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
            tw.Flush();
        }

        starttime = endtime;
        tries = 1;
    }


    // Update is called once per frame
    void Update()
    {
        
        //Log agent movements every frame
        DateTime dt = DateTime.Now;
        using (StreamWriter tw = File.AppendText(tffile))
        {
            tw.WriteLine("{\"header\":{\"seq\":0,\"stamp\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"frame_id\":\"HoloLensPreferenceDemo\"},\"child_frame_id\":\"HoloLens\",\"transform\":{\"translation\":{\"x\":" + Camera.main.transform.position.x + ",\"y\":" + Camera.main.transform.position.y + ",\"z\":" + Camera.main.transform.position.z + "},\"rotation\":{\"x\":" + Camera.main.transform.rotation.x + ",\"y\":" + Camera.main.transform.rotation.y + ",\"z\":" + Camera.main.transform.rotation.z + ",\"w\":" + Camera.main.transform.rotation.w + "}},\"__recorded\":{\"$date\":\"" + dt.ToString("yyyy-MM-dd\\THH:mm:ss\\Z") + "\"},\"topic\":\"tf\"}");
            tw.Flush();
        }

        Agent = CreateRandomString();               // Create individual agent name 
        ts = Time.time;

        //check if player is looking at menu - only then the first action ends and can be logged

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit))                    //menu is being looked at
        {
            tries++;
            if (tries == 1)
            {    //log rest of surveying action here 
                string survey = CreateRandomString();
                string surveytask = CreateRandomString();

                // Write triples file/ end of surveying action

                using (StreamWriter sw = File.AppendText(fileName))
                {
                    endtime = ts;                                   //starttime was saved earlier
                    timename = CreateRandomString();
                    sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode_" + EpisodeName + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + survey + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + survey + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + survey + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + survey + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#isPerformedBy\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson_" + Agent + "\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson_" + Agent + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson_" + Agent + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalBegin\",\"o\":{\"$numberDecimal\": \"" + starttime + "\"}},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalEnd\",\"o\":{\"$numberDecimal\": \"" + endtime + "\"}},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + survey + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\"},");
                    sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + survey + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#AreaSurveying_" + surveytask + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
                    sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#AreaSurveying_" + surveytask + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                    sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#AreaSurveying_" + surveytask + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#AreaSurveying\"},");
                    sw.Flush();
                    starttime = endtime;                // endtime of first action becomes starttime of next action

                }
            }
            else
            {
                if (tries == 2)
                {
                    string LookFor = CreateRandomString();
                    string LookFTsk = CreateRandomString();
                    string NavTsk = CreateRandomString();
                    string Create = CreateRandomString();
                    string CreObj = CreateRandomString();

                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        endtime = ts;                                   //starttime was saved earlier
                        timename = CreateRandomString();

                        // Log LookingFor action
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Episode_" + EpisodeName + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#startedBy\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Tapping_" + Taptsk + "\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalBegin\",\"o\":{\"$numberDecimal\": \"" + starttime + "\"}},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#hasIntervalEnd\",\"o\":{\"$numberDecimal\": \"" + endtime + "\"}},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval_" + timename + "\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#isPerformedBy\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson_" + Agent + "\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingFor_" + LookFTsk + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingFor_" + LookFTsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingFor\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingFor_" + LookFTsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#LookingFor_" + LookFTsk + "\",\"p\":\"http://www.ease-crc.org/ont/SOMA.owl#starts\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Creation_" + Create + "\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesRole\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Creation_" + Create + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Creation_" + Create + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Creation\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Creation_" + Create + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Creation_" + Create + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#defines\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + CreObj + "\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + CreObj + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + CreObj + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + CreObj + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#CommitedObject_" + CreObj + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#DigitalObject\"},");
                        sw.WriteLine("{\"s\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action_" + LookFor + "\",\"p\":\"http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Navigating_" + NavTsk + "\",\"since\":" + starttime + ",\"until\":" + endtime + "},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Navigating_" + NavTsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.ease-crc.org/ont/SOMA.owl#Navigating\"},");
                        sw.WriteLine("{\"s\":\"http://www.ease-crc.org/ont/SOMA.owl#Navigating_" + NavTsk + "\",\"p\":\"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\",\"o\":\"http://www.w3.org/2002/07/owl#NamedIndividual\"},");
                        sw.Flush();
                        starttime = endtime;                // endtime of first action becomes starttime of next action

                    }
                }
            }
            
        }
        
    }

}
