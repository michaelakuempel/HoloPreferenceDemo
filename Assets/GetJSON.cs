﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;



public class GetJSON : MonoBehaviour
{
    //List<string> EANlistPreservatives = new List<string>("4002448065111", "4010355592118", "4058172509377", "4058172179648", "4058172051845", "4058172051869", "4058172509117", "4058172491306", "4058172509681", "4058172453151", "4058172508851", "4058172336652", "4058172470080", "4058172470066", "8710908769085", "8710908778148");

    //Objects in Regal1
    public GameObject EAN4002448065111;
    public GameObject EAN4002448065111_2;
    public GameObject EAN8710447348697_2;
    public GameObject EAN8001841531144_2;
    public GameObject EAN4002448046424;
    public GameObject EAN4058172180415;
    public GameObject EAN4058172180415_2;
    public GameObject EAN4058172180415_3;
    public GameObject EAN4058172180415_4;
    public GameObject EAN4010355326508;
    public GameObject EAN4010355485793;
    public GameObject EAN4010355319982;
    public GameObject EAN4010355558671;
    public GameObject EAN8714789952581;
    public GameObject EAN8714789952581_2;
    public GameObject EAN4058172470080;
    public GameObject EAN4058172470080_2;
    public GameObject EAN4002448128533;
    public GameObject EAN8001841531144;
    public GameObject EAN4058172470066;
    public GameObject EAN8710447348697;
    public GameObject EAN4010355485632;
    public GameObject EAN4010355558671_2;
    public GameObject EAN8710447348697_3;
    public GameObject EAN8001841531144_3;
    public GameObject EAN8001841531144_4;
    public GameObject EAN4010355485632_2;
    public GameObject EAN4058172470066_2;

    //Objects in Regal2
    public GameObject EAN8710908769085;
    public GameObject EAN8710908769085_2;
    public GameObject EAN8710908778148;
    public GameObject EAN8710908778148_2;
    public GameObject EAN4010355592118;
    public GameObject EAN4010355592118_2;
    public GameObject EAN4058172456473;
    public GameObject EAN4058172508875;
    public GameObject EAN4058172509377;
    public GameObject EAN4058172491610;
    public GameObject EAN4058172491610_2;
    public GameObject EAN4058172051869;
    public GameObject EAN4058172051883;
    public GameObject EAN4058172179648;
    public GameObject EAN4058172509117;
    public GameObject EAN4058172491306;
    public GameObject EAN4058172509681;
    public GameObject EAN4058172453151;
    public GameObject EAN4058172509056;
    public GameObject EAN4058172509056_2;
    public GameObject EAN4058172509056_3;
    public GameObject EAN4058172508851;
    public GameObject EAN4058172051845;
    public GameObject EAN8710908778148_3;
    public GameObject EAN4058172456473_2;
    public GameObject EAN4058172491306_2;
    public GameObject EAN4058172179648_2;
    public GameObject EAN4058172509681_2;
    public GameObject EAN4058172491306_3;
    public GameObject EAN4058172491306_4;
    public GameObject EAN4058172509056_4;
    public GameObject EAN4058172509056_5;

    //SetInvisible is called at start and after anchoring objects to their correct positions
    public void SetInvisible()
    {
    EAN4002448065111.SetActive(false);
    EAN4002448065111_2.SetActive(false);
    EAN8710447348697_2.SetActive(false);
    EAN8001841531144_2.SetActive(false);
    EAN4002448046424.SetActive(false);
    EAN4058172180415.SetActive(false);
    EAN4058172180415_2.SetActive(false);
    EAN4058172180415_3.SetActive(false);
    EAN4058172180415_4.SetActive(false);
    EAN4010355326508.SetActive(false);
    EAN4010355485793.SetActive(false);
    EAN4010355319982.SetActive(false);
    EAN4010355558671.SetActive(false);
    EAN8714789952581.SetActive(false);
    EAN8714789952581_2.SetActive(false);
    EAN4058172470080.SetActive(false);
    EAN4058172470080_2.SetActive(false);
    EAN4002448128533.SetActive(false);
    EAN8001841531144.SetActive(false);
    EAN4058172470066.SetActive(false);
    EAN8710447348697.SetActive(false);
    EAN4010355485632.SetActive(false);
    EAN4010355558671_2.SetActive(false);
    EAN8710447348697_3.SetActive(false);
    EAN8001841531144_3.SetActive(false);
    EAN8001841531144_4.SetActive(false);
    EAN4010355485632_2.SetActive(false);
    EAN4058172470066_2.SetActive(false);

    EAN8710908769085.SetActive(false);
    EAN8710908769085_2.SetActive(false);
    EAN8710908778148.SetActive(false);
    EAN8710908778148_2.SetActive(false);
    EAN4010355592118.SetActive(false);
    EAN4010355592118_2.SetActive(false);
    EAN4058172456473.SetActive(false);
    EAN4058172508875.SetActive(false);
    EAN4058172509377.SetActive(false);
    EAN4058172491610.SetActive(false);
    EAN4058172491610_2.SetActive(false);
    EAN4058172051869.SetActive(false);
    EAN4058172051883.SetActive(false);
    EAN4058172179648.SetActive(false);
    EAN4058172509117.SetActive(false);
    EAN4058172491306.SetActive(false);
    EAN4058172509681.SetActive(false);
    EAN4058172453151.SetActive(false);
    EAN4058172509056.SetActive(false);
    EAN4058172509056_2.SetActive(false);
    EAN4058172509056_3.SetActive(false);
    EAN4058172508851.SetActive(false);
    EAN4058172051845.SetActive(false);
    EAN8710908778148_3.SetActive(false);
    EAN4058172456473_2.SetActive(false);
    EAN4058172491306_2.SetActive(false);
    EAN4058172179648_2.SetActive(false);
    EAN4058172509681_2.SetActive(false);
    EAN4058172491306_3.SetActive(false);
    EAN4058172491306_4.SetActive(false);
    EAN4058172509056_4.SetActive(false);
    EAN4058172509056_5.SetActive(false);
}

    //SetVisible is calles when anchoring the objects to their correct location
    public void SetVisible()
    {
        EAN4002448065111.SetActive(true);
        EAN4002448065111_2.SetActive(true);
        EAN8710447348697_2.SetActive(true);
        EAN8001841531144_2.SetActive(true);
        EAN4002448046424.SetActive(true);
        EAN4058172180415.SetActive(true);
        EAN4058172180415_2.SetActive(true);
        EAN4058172180415_3.SetActive(true);
        EAN4058172180415_4.SetActive(true);
        EAN4010355326508.SetActive(true);
        EAN4010355485793.SetActive(true);
        EAN4010355319982.SetActive(true);
        EAN4010355558671.SetActive(true);
        EAN8714789952581.SetActive(true);
        EAN8714789952581_2.SetActive(true);
        EAN4058172470080.SetActive(true);
        EAN4058172470080_2.SetActive(true);
        EAN4002448128533.SetActive(true);
        EAN8001841531144.SetActive(true);
        EAN4058172470066.SetActive(true);
        EAN8710447348697.SetActive(true);
        EAN4010355485632.SetActive(true);
        EAN4010355558671_2.SetActive(true);
        EAN8710447348697_3.SetActive(true);
        EAN8001841531144_3.SetActive(true);
        EAN8001841531144_4.SetActive(true);
        EAN4010355485632_2.SetActive(true);
        EAN4058172470066_2.SetActive(true);

        EAN8710908769085.SetActive(true);
        EAN8710908769085_2.SetActive(true);
        EAN8710908778148.SetActive(true);
        EAN8710908778148_2.SetActive(true);
        EAN4010355592118.SetActive(true);
        EAN4010355592118_2.SetActive(true);
        EAN4058172456473.SetActive(true);
        EAN4058172508875.SetActive(true);
        EAN4058172509377.SetActive(true);
        EAN4058172491610.SetActive(true);
        EAN4058172491610_2.SetActive(true);
        EAN4058172051869.SetActive(true);
        EAN4058172051883.SetActive(true);
        EAN4058172179648.SetActive(true);
        EAN4058172509117.SetActive(true);
        EAN4058172491306.SetActive(true);
        EAN4058172509681.SetActive(true);
        EAN4058172453151.SetActive(true);
        EAN4058172509056.SetActive(true);
        EAN4058172509056_2.SetActive(true);
        EAN4058172509056_3.SetActive(true);
        EAN4058172508851.SetActive(true);
        EAN4058172051845.SetActive(true);
        EAN8710908778148_3.SetActive(true);
        EAN4058172456473_2.SetActive(true);
        EAN4058172491306_2.SetActive(true);
        EAN4058172179648_2.SetActive(true);
        EAN4058172509681_2.SetActive(true);
        EAN4058172491306_3.SetActive(true);
        EAN4058172491306_4.SetActive(true);
        EAN4058172509056_4.SetActive(true);
        EAN4058172509056_5.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Set all gameobjects invisible
        SetInvisible();
        //StartREST("Preservative"); //Testcall in Simulation
    }

    //public function to start REST call, iniiated when a toggle is activated
    public void StartREST(string preference)
    {
        SetInvisible();
        if (preference == "Fragrance")
        {
            List<string> EANlistFragrance = new List<string> { "4058172179648","4058172509117","4010355592118","4058172509377","4058172051845","4058172051883","4058172051869","4058172509681","4058172453151","4058172508851","4058172508875","4058172336652","8710908769085","8714789952581","4002448128533","4058172470066","4058172491306","8710908778148","4058172456473","8001841531144","4058172509056","4058172470080","4010355326508","4010355485793","4010355319982","4058172180415","8710447348697",};
            
            ProcessResponse(EANlistFragrance);
        }
        if(preference == "Mineraloil")
        {
            List<string> EANlistMineroil = new List<string> { "8710908769085", "8710908778148" };
           
            ProcessResponse(EANlistMineroil);
        }
        if(preference == "Toxin")
        {
            List<string> EANlistParabene = new List<string> { "8714789952581","4010355485793", "4010355319982", "4058172180415", "4010355558671" };
            
            ProcessResponse(EANlistParabene);
        }
        if(preference == "Preservative")
        {
            List<string> EANlistPreservatives = new List<string> { "4002448065111", "4010355592118", "4058172509377", "4058172179648", "4058172051845", "4058172051869", "4058172509117", "4058172491306", "4058172509681", "4058172453151", "4058172508851", "4058172336652", "4058172470080", "4058172470066", "8710908769085", "8710908778148" };
            
            ProcessResponse(EANlistPreservatives);
        }
        if (preference == "vegetarian")
        {
            List<string> EANlistvegetarian = new List<string> { "4001638094764","400163809801","4001638098083","4001638098090","4005120163181","4010355000903","4010355003225","4010355059642","4010355059741","4010355080691","4010355080998","4010355090935","4010355117069","4010355117106","4010355117144","4010355120250","4010355120571","4010355130457","4010355135193","4010355135278","4010355135339","4010355141217","4010355170026","4010355181510","4010355195043","4010355195180","4010355196866","4010355197504","4010355197528","4010355197566","4010355197948","4010355197962","4010355212269","4010355215864","4010355216045","4010355221261","4010355235794","4010355235817","4010355235879","4010355235978","4010355236135","4010355236197","4010355236333","4010355236418","4010355247148","4010355248749","4010355248770","4010355248800","4010355248831","4010355253002","4010355253613","4010355267191","4010355267283","4010355267580","4010355298102","4010355298126","4010355298164","4010355298225","4010355299482","4010355299666","4010355300188","4010355300201","4010355300300","4010355301604","4010355306777","4010355306852","4010355307170","4010355319005","4010355319142","4010355319180","4010355319203","4010355319227","4010355319340","4010355319364","4010355319401","4010355319425","4010355320568","4010355320582","4010355322852","4010355323019","4010355323057","4010355323071","4010355323156","4010355326348","4010355328151","4010355340016","4010355340054","4010355340078","4010355340092","4010355340955","4010355341136","4010355343185","4010355343208","4010355343222","4010355343345","4010355345653","4010355346438","4010355348388","4010355351401","4010355370396","4010355374806","4010355374837","4010355374868","4010355374899","4010355383013","4010355383037","4010355383280","4010355383419","4010355384522","4010355386311","4010355386328","4010355388261","4010355391032","4010355407641","4010355409676","4010355410016","4010355414809","4010355414830","4010355439826","4010355440587","4010355440600","4010355440624","4010355440648","4010355440662","4010355473547","4010355473561","4010355474797","4010355476258","4010355482594","4010355482617","4010355486639","4010355513854","4010355514219","4010355514240","4010355518699","4010355518712","4010355539823","4010355558299","4010355558329","4010355558343","4010355558411","4010355558503","4010355558534","4010355585691","4010355585813","4010355596048","4010355596062","4010355596086","4010355929631","4010355966223","4010355992512","4010355995308","4010355995339","4010355995360","4010355995575","4021457613564","4021457613601","4021457613625","4021457613687","4021457613830","4021457616763","4021457616800","4021457616831","4021457616862","4021457616930","4021457616992","4021457617012","4021457618866","4021457621347","4021457622245","4021457622276","4021457623570","4033082021225","4033419520100","4045612000723","4045612005483","4045612005490","4045612005544","4045612005551","4051424558659","4051424558673","4051424558697","4051424558796","4058172009754","4058172024184","4058172062995","4062300227682","4260372933610","4260372933627","4260372933634","4260484410016","4260484410030","4260484410054","4260484410092","5000468000609","5014697017086","5014697017109","50270279","5060144644718","5060144644732","5060144645524","5060144645531","5060144645548","8718951056039"};
            ProcessResponse(EANlistvegetarian);
        }
        if (preference == "vegan")
        {
            List<string> EANlistvegan = new List<string> { "4001638098083", "4001638098090" };
            ProcessResponse(EANlistvegan);
        }
        if (preference == "eco")
        {
            List<string> EANlisteco = new List<string> { "4001638094764","4001638098014","4001638098083","4001638098090","4005120163181","4010355000903","4010355003225","4010355059642","4010355059741","4010355080691","4010355080998","4010355090935","4010355117069","4010355117106","4010355117144","4010355120250","4010355120571","4010355130457","4010355135193","4010355135278","4010355135339","4010355141217","4010355170026","4010355181510","4010355195043","4010355195180","4010355196866","4010355197504","4010355197528","4010355197566","4010355197948","4010355197962","4010355212269","4010355215864","4010355216045","4010355221261","4010355235794","4010355235817","4010355235879","4010355235978","4010355236135","4010355236197","4010355236333","4010355236418","4010355247148","4010355248749","4010355248770","4010355248800","4010355248831","4010355253002","4010355253613","4010355267191","4010355267283","4010355267580","4010355298102","4010355298126","4010355298164","4010355298225","4010355299482","4010355299666","4010355300188","4010355300201","4010355300300","4010355301604","4010355306777","4010355306852","4010355307170","4010355319005","4010355319142","4010355319180","4010355319203","4010355319227","4010355319340","4010355319364","4010355319401","4010355319425","4010355320568","4010355320582","4010355322852","4010355323019","4010355323057","4010355323071","4010355323156","4010355326348","4010355328151","4010355340016","4010355340054","4010355340078","4010355340092","4010355340955","4010355341136","4010355343185","4010355343208","4010355343222","4010355343345","4010355345653","4010355346438","4010355348388","4010355351401","4010355370396","4010355374806","4010355374837","4010355374868","4010355374899","4010355383013","4010355383037","4010355383280","4010355383419","4010355384522","4010355386311","4010355386328","4010355388261","4010355391032","4010355407641","4010355409676","4010355410016","4010355414809","4010355414830","4010355439826","4010355440587","4010355440600","4010355440624","4010355440648","4010355440662","4010355473547","4010355473561","4010355474797","4010355476258","4010355482594","4010355482617","4010355486639","4010355513854","4010355514219","4010355514240","4010355518699","4010355518712","4010355539823","4010355558299","4010355558329","4010355558343","4010355558411","4010355558503","4010355558534","4010355585691","4010355585813","4010355596048","4010355596062","4010355596086","4010355929631","4010355966223","4010355992512","4010355995308","4010355995339","4010355995360","4010355995575","4021457613564","4021457613601","4021457613625","4021457613687","4021457613830","4021457616763","4021457616800","4021457616831","4021457616862","4021457616930","4021457616992","4021457617012","4021457618866","4021457621347","4021457622245","4021457622276","4021457623570","4033082021225","4033419520100","4045612000723","4045612005483","4045612005490","4045612005544","4045612005551","4051424558659","4051424558673","4051424558697","4051424558796","4058172009754","4058172024184","4058172062995","4062300227682","4260372933610","4260372933627","4260372933634","4260484410016","4260484410030","4260484410054","4260484410092","5000468000609","5014697017086","5014697017109","50270279","5060144644718","5060144644732","5060144645524","5060144645531","5060144645548","8718951056039" };
            ProcessResponse(EANlisteco);
        }
        if (preference == "synch")
        {
            List<string> EANlistsynth = new List<string> { "4010355010216","4010355951489","4010355410719","4010355653390","4010355450722","4010355673022","4010355450722","4010355653390","4010355653451","4010355673022","4010355653352","4010355895127","4010355653451"
 };
            ProcessResponse(EANlistsynth);
        }
        if (preference == "sweet")
        {
            List<string> EANlistsweet = new List<string> { "4005808224005","4005808801640","4009932001259","4010355059642","4010355248770","4010355339324","4010355374806","4010355374868","4010355374899","4010355440587","4010355440600","4010355440624","4010355440662","4010355992512","50076598","54024502","8710447469149","8710447469170","8712561521840","8712561856447","8718114202372","4009932004526" };
            ProcessResponse(EANlistsweet);
        }
        if (preference == "NutriA")
        {
            List<string> EANlistNutri = new List<string> { "" };
            ProcessResponse(EANlistNutri);
        }
        if (preference == "alcohol")
        {
            List<string> EANlistalcohol = new List<string> { "4010355416919","3574661259895","3600523581344","3600523606276","3600540897794","3600540901187","4001638080262","4001638089654","4001638094757","4001638094764","4005808745098","4005808789382","4005900471109","4005900471796","4010355003225","4010355059642","4010355059741","4010355090935","4010355117106","4010355117144","4010355135339","4010355206848","4010355215864","4010355253002","4010355267467","4010355274076","4010355298188","4010355306777","4010355307170","4010355319142","4010355319180","4010355319203","4010355319227","4010355319340","4010355319364","4010355319401","4010355319425","4010355319548","4010355326348","4010355339324","4010355340955","4010355341136","4010355341792","4010355341815","4010355348388","4010355383037","4010355410016","4010355482594","4010355558503","4010355585486","4010355585691","4010355596048","4010355596086","4010355996091","40133218","40133249","4015000960847","4021457613564","4021457613571","4021457613601","4021457613687","4021457616992","4021457622276","4051424558659","4051424558673","4051424558697","4260484410016","4260484410030","4260484410054","4260484410092","50076598","50262816","54024502","8710447211267","8710447447499","8710447469132","8710447469149","8710447469170","8710908489150","8710908489532","8710908768507","8710908769085","8710908769153","8712561521840","8712561855563","8712561856300","8712561856447","8717644566237","8718114202372","8718951226890","3574661261096","3600522334248","3600523349692","3600523577002","3600523638352","4005808745098","4005808801640","4005900215239","4005900383174","4005900471796","4008491276085","4008617010159","4010355059666","4010355181510","4010355197528","4010355215864","4010355235817","4010355235879","4010355236111","4010355236333","4010355236555","4010355236579","4010355298164","4010355298225","4010355300423","4010355300614","4010355319180","4010355319203","4010355319227","4010355323071","4010355340054","4010355340955","4010355384522","4010355386311","4010355386328","4010355439826","4010355482594","4010355482617","4010355518699","4010355518712","4010355539823","4010355556554","4010355992512","4016566052304","4025089073789","4037900284694","4045612000723","4056500008714","4058172043444","4260372933610","5000468000609","50099962","5014697017086","5014697017109","50262816","8710447211267","8710447447499","8710447469132","3600522233039","4005808789382","4005900471109","4009241370008","4010355003225","4010355121110","4010355195043","4010355197481","4010355197566","4010355235794","4010355247056","4010355306777","4010355320582","4010355346490","4010355346513","4010355440587","4010355440600","4010355929631","40133249","4021457613687","4021457616831","4021457616930","4021457622276","4051424558659","4051424558673","4051424558697","4051424558796","8710908489150","8710908768910","8710908769085","8710908769153","8710908769221","8710908776519","8710908778148","8712561856447","3600522418832","3600523581344","3600523349692","3600540897794","4001638088763","4005120163181","4005808206995","4005808223336","4005808224005","4005900229175","4008491444262","4010355003225","4010355039934","4010355059642","4010355059741","4010355080691","4010355117106","4010355117144","4010355120557","4010355120571","4010355170026","4010355195043","4010355197504","4010355197528","4010355197566","4010355206824","4010355206848","4010355246448","4010355246462","4010355247056","4010355248770","4010355248800","4010355248831","4010355253002","4010355267191","4010355267467","4010355298126","4010355298140","4010355298188","4010355299482","4010355299666","4010355300188","4010355300201","4010355300300","4010355306777","4010355319142","4010355319227","4010355319340","4010355319364","4010355319401","4010355319548","4010355320568","4010355322852","4010355323057","4010355323071","4010355326348","4010355340016","4010355340078","4010355340092","4010355340696","4010355341136","4010355341792","4010355345653","4010355346414","4010355346438","4010355351401","4010355370013","4010355370396","4010355374806","4010355374837","4010355374899","4010355383037","4010355383280","4010355388261","4010355391032","4010355410016","4010355414809","4010355440587","4010355440600","4010355518699","4010355518712","4010355558299","4010355558503","4010355558534","4010355585691","4010355585813","4010355596062","4010355596086","4010355929631","4010355992192","4010355992413","4010355996091","40133218","4021457613564","4021457613601","4021457613625","4021457613687","4021457616831","4021457616930","4021457616992","4021457618866","4021457622276","4051424558659","4051424558673","4260372933610","4260372933627","4260484410016","4260484410030","4260484410054","4260484410092","8710908489532","8712561855563","8712561856300","3600523606276","4001638080262","4001638080316","4001638081870","4001638086004","4001638086561","4001638086882","4001638088763","4001638089654","4001638093989","4001638095723","4001638098014","4001638098069","4001638098083","4001638098090","4005120163181","4009903055557","4010355003225","4010355117069","4010355117106","4010355117144","4010355135278","4010355206848","4010355212269","4010355217875","4010355236555","4010355236579","4010355248770","4010355248800","4010355248831","4010355253002","4010355253392","4010355253613","4010355299666","4010355306777","4010355306852","4010355307170","4010355319401","4010355326348","4010355343185","4010355343208","4010355343222","4010355345653","4010355351401","4010355370396","4010355374837","4010355374868","4010355374899","4010355383013","4010355383037","4010355383280","4010355383419","4010355388261","4010355391032","4010355414809","4010355414830","4010355474797","4010355483638","4010355558299","4010355558329","4010355558411","4010355558503","4010355558534","4010355585691","4010355992512","4021457613564","4021457613571","4021457613601","4021457613625","4021457613687","4021457613809","4021457616763","4021457616800","4021457616824","4021457616831","4021457616862","4021457616930","4021457616992","4021457617012","4021457618866","4021457621347","4021457622245","4021457622276","4021457623570","4051424558659","4051424558673","4051424558697","4051424558796","4058172009754","5060144645524","5060144645531","5060144645548","4005900229175","4010355195180","4010355197481","4010355197566","4010355235794","4010355236135","4010355440587","4010355440600","4010355440662","4010355929631","4051424558659","4051424558673","4051424558697","50076598","54024502","4008233010946","4008233010946","4010355003225","4010355117069","4010355117106","4010355117144","4010355181510","4010355248770","4010355248800","4010355248831","4010355253002","4010355253392","4010355253613","4010355306777","4010355306852","4010355307170","4010355383013","4010355383037","4010355383419","4010355386328","4010355388261","4010355414830","4010355518699","4010355518712","4010355558299","4010355558329","4010355558343","4010355558503","4010355558534","4010355003225","4010355306777","4010355022400","4010355039934","4010355080691","4010355080998","4010355120571","4010355120656","4010355197528","4010355235978","4010355299666","4010355300188","4010355300300","4010355340016","4010355340078","4010355340092","4010355384560","4010355414809","4010355929631","4010355966223","4010355992413","4010355106902","4010355120656","4010355248831","4010355267191","4010355340696","4010355992192","4010355992512","4010355117106","4010355117144","4010355253002","4010355351401","4010355383037","4010355518699","4010355518712","4010355558299","4010355558503","4010355558534","4010355117144","4010355170026","4010355440624","4010355440662","4010355197566","4010355351401","4010355374837","4010355374899","4021457613564","4021457616992","4010355253392","4010355267313","4010355513854","4010355539823","4058172043444","4010355274076","4010355328151","40133249","4033082021225","4033082021249","4010355299666","4010355966223","4010355306852","4010355319401","4010355328380","4010355826046","4010355343345","4010355351401","4010355386311","4010355388261","4010355440624","4010355826046","40133249","8710908489532","8712561521840","8717644566237","8718114202372" };
            ProcessResponse(EANlistalcohol);
        }
    }
     
    private void ProcessResponse(List<String> values)
    {
                
        foreach (string item in values)
        {

            //Handler to go through result list and set gameobjects visible
            if (item.Contains("4002448046424"))
            {
                EAN4002448046424.SetActive(true);
            }
            if (item.Contains("4002448065111"))
            {
                EAN4002448065111.SetActive(true);
                EAN4002448065111_2.SetActive(true);
            }
            if (item.Contains("4002448128533"))
            {
                EAN4002448128533.SetActive(true);
            }
            if (item.Contains("4010355319982"))
            {
                EAN4010355319982.SetActive(true);
            }
            if (item.Contains("4010355326508"))
            {
                EAN4010355326508.SetActive(true);
            }
            if (item.Contains("4010355485632"))
            {
                EAN4010355485632.SetActive(true);
                EAN4010355485632_2.SetActive(true);
            }
            if (item.Contains("4010355485793"))
            {
                EAN4010355485793.SetActive(true);
            }
            if (item.Contains("4010355558671"))
            {
                EAN4010355558671.SetActive(true);
                EAN4010355558671_2.SetActive(true);
            }
            if (item.Contains("4010355592118"))
            {
                EAN4010355592118.SetActive(true);
                EAN4010355592118_2.SetActive(true);
            }
            if (item.Contains("4058172051845"))
            {
                EAN4058172051845.SetActive(true);
            }
            if (item.Contains("4058172051869"))
            {
                EAN4058172051869.SetActive(true);
            }
            if (item.Contains("4058172051883"))
            {
                EAN4058172051883.SetActive(true);
            }
            if (item.Contains("4058172179648"))
            {
                EAN4058172179648.SetActive(true);
                EAN4058172179648_2.SetActive(true);
            }
            if (item.Contains("4058172180415"))
            {
                EAN4058172180415.SetActive(true);
                EAN4058172180415_2.SetActive(true);
                EAN4058172180415_3.SetActive(true);
                EAN4058172180415_4.SetActive(true);
            }
            if (item.Contains("4058172453151"))
            {
                EAN4058172453151.SetActive(true);
            }
            if (item.Contains("4058172456473"))
            {
                EAN4058172456473.SetActive(true);
                EAN4058172456473_2.SetActive(true);
            }
            if (item.Contains("4058172470066"))
            {
                EAN4058172470066.SetActive(true);
                EAN4058172470066_2.SetActive(true);
            }
            if (item.Contains("4058172470080"))
            {
                EAN4058172470080.SetActive(true);
                EAN4058172470080_2.SetActive(true);
            }
            if (item.Contains("4058172491306"))
            {
                EAN4058172491306.SetActive(true);
                EAN4058172491306_2.SetActive(true);
                EAN4058172491306_3.SetActive(true);
                EAN4058172491306_4.SetActive(true);
            }
            if (item.Contains("4058172491610"))
            {
                EAN4058172491610.SetActive(true);
                EAN4058172491610_2.SetActive(true);
            }
            if (item.Contains("4058172508851"))
            {
                EAN4058172508851.SetActive(true);
            }
            if (item.Contains("4058172508875"))
            {
                EAN4058172508875.SetActive(true);
            }
            if (item.Contains("4058172509056"))
            {
                EAN4058172509056.SetActive(true);
                EAN4058172509056_2.SetActive(true);
                EAN4058172509056_3.SetActive(true);
                EAN4058172509056_4.SetActive(true);
                EAN4058172509056_5.SetActive(true);
            }
            if (item.Contains("4058172509117"))
            {
                EAN4058172509117.SetActive(true);
            }
            if (item.Contains("4058172509377"))
            {
                EAN4058172509377.SetActive(true);
            }
            if (item.Contains("4058172509681"))
            {
                EAN4058172509681.SetActive(true);
                EAN4058172509681_2.SetActive(true);
            }
            if (item.Contains("8001841531144"))
            {
                EAN8001841531144.SetActive(true);
                EAN8001841531144_2.SetActive(true);
                EAN8001841531144_3.SetActive(true);
                EAN8001841531144_4.SetActive(true);
            }
            if (item.Contains("8710447348697"))
            {
                EAN8710447348697.SetActive(true);
                EAN8710447348697_2.SetActive(true);
                EAN8710447348697_3.SetActive(true);
            }
            if (item.Contains("8710908769085"))
            {
                EAN8710908769085.SetActive(true);
                EAN8710908769085_2.SetActive(true);
            }
            if (item.Contains("8710908778148"))
            {
                EAN8710908778148.SetActive(true);
                EAN8710908778148_2.SetActive(true);
                EAN8710908778148_3.SetActive(true);
            }
            if (item.Contains("8714789952581"))
            {
                EAN8714789952581.SetActive(true);
                EAN8714789952581_2.SetActive(true);
            }
            if (item.Contains("4058172179648"))
            {
                EAN4058172179648.SetActive(true);
                EAN4058172179648_2.SetActive(true);
            }
            if (item.Contains("4058172051845"))
            {
                EAN4058172051845.SetActive(true);
            }
            if (item.Contains("4058172051869"))
            {
                EAN4058172051869.SetActive(true);
            }
            if (item.Contains("4058172509117"))
            {
                EAN4058172509117.SetActive(true);
            }
            if (item.Contains("4058172491306"))
            {
                EAN4058172491306.SetActive(true);
                EAN4058172491306_2.SetActive(true);
                EAN4058172491306_3.SetActive(true);
                EAN4058172491306_4.SetActive(true);
            }
            if (item.Contains("4058172509681"))
            {
                EAN4058172509681.SetActive(true);
                EAN4058172509681_2.SetActive(true);
            }
            if (item.Contains("4058172453151"))
            {
                EAN4058172453151.SetActive(true);
            }
            if (item.Contains("4058172508851"))
            {
                EAN4058172508851.SetActive(true);
            }
            if (item.Contains("4058172470080"))
            {
                EAN4058172470080.SetActive(true);
                EAN4058172470080_2.SetActive(true);
            }
            if (item.Contains("4058172470066"))
            {
                EAN4058172470066.SetActive(true);
                EAN4058172470066_2.SetActive(true);
            }
            if (item.Contains("8710908769085"))
            {
                EAN8710908769085.SetActive(true);
                EAN8710908769085_2.SetActive(true);
            }
            if (item.Contains("8710908778148"))
            {
                EAN8710908778148.SetActive(true);
                EAN8710908778148_2.SetActive(true);
                EAN8710908778148_3.SetActive(true);
            }
            
        }

    }

    
}