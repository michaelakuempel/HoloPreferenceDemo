using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class RESTGet : MonoBehaviour
{
    //string FragranceURL = "http://localhost:7200/repositories/K4R_RtoP?action=QUERY?name=ProductwithFragranceAllergen&infer=true&sameAs=true&query=PREFIX%20rdfs%3A%20%3Chttp%3A%2F%2Fwww.w3.org%2F2000%2F01%2Frdf-schema%23%3E%0APREFIX%20rdf%3A%20%3Chttp%3A%2F%2Fwww.w3.org%2F1999%2F02%2F22-rdf-syntax-ns%23%3E%0APREFIX%20owl%3A%20%3Chttp%3A%2F%2Fwww.w3.org%2F2002%2F07%2Fowl%23%3E%0Aprefix%20pp%3A%20%3Chttp%3A%2F%2Fknowrob.org%2Fkb%2FProductPoses.owl%23%3E%0Aprefix%20dm%3A%20%3Chttp%3A%2F%2Fknowrob.org%2Fkb%2Fdmproducts.owl%23%3E%0Aprefix%20gr%3A%20%3Chttp%3A%2F%2Fpurl.org%2Fgoodrelations%2Fv1%23%3E%0A%0Aselect%20distinct%20%3FEAN%20%7B%20%0A%20%20%20%20%3Finstance%20gr%3AhasEAN_UCC-13%20%3FEAN.%0A%20%20%20%20%3Finstance%20dm%3AhasIngredient%20%3Fallergen.%0A%20%20%20%20%3Fallergen%20rdf%3Atype%20dm%3AFragrance.%0A%7D%20%0A";
    //string ParabeneURL = "http://localhost:7200/repositories/K4R_RtoP?action=QUERY?name=ProductwithParabeneAllergen&infer=true&sameAs=true&query=PREFIX%20rdf%3A%20%3Chttp%3A%2F%2Fwww.w3.org%2F1999%2F02%2F22-rdf-syntax-ns%23%3E%0Aprefix%20dm%3A%20%3Chttp%3A%2F%2Fknowrob.org%2Fkb%2Fdmproducts.owl%23%3E%0Aprefix%20gr%3A%20%3Chttp%3A%2F%2Fpurl.org%2Fgoodrelations%2Fv1%23%3E%0A%0Aselect%20distinct%20%3FEAN%20%7B%20%0A%20%20%20%20%3Finstance%20gr%3AhasEAN_UCC-13%20%3FEAN.%0A%20%20%20%20%3Finstance%20dm%3AhasIngredient%20%3Fallergen.%0A%20%20%20%20%3Fallergen%20rdf%3Atype%20dm%3AParaben.%0A%7D%20%0A";
    //string PreservativeURL = "http://localhost:7200/repositories/K4R_RtoP?action=QUERY?name=ProductwithPreservativeAllergen&infer=true&sameAs=true&query=PREFIX%20rdf%3A%20%3Chttp%3A%2F%2Fwww.w3.org%2F1999%2F02%2F22-rdf-syntax-ns%23%3E%0Aprefix%20dm%3A%20%3Chttp%3A%2F%2Fknowrob.org%2Fkb%2Fdmproducts.owl%23%3E%0Aprefix%20gr%3A%20%3Chttp%3A%2F%2Fpurl.org%2Fgoodrelations%2Fv1%23%3E%0A%0Aselect%20distinct%20%3FEAN%20%7B%20%0A%20%20%20%20%3Finstance%20gr%3AhasEAN_UCC-13%20%3FEAN.%0A%20%20%20%20%3Finstance%20dm%3AhasIngredient%20%3Fallergen.%0A%20%20%20%20%3Fallergen%20rdf%3Atype%20dm%3APreservative.%0A%7D%20%0A";

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

    // Start is called before the first frame update
    void Start()
    {
        //Set all gameobjects invisible
        //SetInvisible();
        //StartCoroutine(GetData(PreservativeURL));
        StartREST("Preservative");
    }

    //public function to start REST call, iniiated when a toggle is activated
    public void StartREST(string preference)
    {

        if (preference == "Fragrance")
        {
            string[] FragranceEANs = System.IO.File.ReadAllLines(@"C:\Users\micha\OneDrive\Documents\UnityProjects\NoExtrasRoomObjects\LabAppMitAnchor\PreservativeEANs.txt");
            ProcessResponse(FragranceEANs);
        }
        if(preference == "Parabene")
        {
            //StartCoroutine(GetData(ParabeneURL));
        }
        if(preference == "Preservative")
        {
            SetInvisible();
            string[] PreservativeEANs = System.IO.File.ReadAllLines(@"C:\Users\micha\OneDrive\Documents\UnityProjects\NoExtrasRoomObjects\LabAppMitAnchor\PreservativeEANs.txt");
            ProcessResponse(PreservativeEANs);
        }
        
    }

    /*IEnumerator GetData(string uri)
    {
        //Debug.Log("Processing Website");

        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Call/Request website and wait to finish download
            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError)
            {
                Debug.Log("No response from website");
            }
            else
            {
                Debug.Log(webRequest.downloadHandler.text);
                ProcessResponse(webRequest.downloadHandler.text);
            }
        }
    }*/

    private void ProcessResponse(string[] EANlist)
    {
        foreach (string responsetext in EANlist)
        {
            Debug.Log("EAN found:" + responsetext);
            //Handler to go through result list and set gameobjects visible
            if (responsetext.Contains("4002448065111"))
            {
                EAN4002448065111.SetActive(true);
                EAN4002448065111_2.SetActive(true);
            }
            else
            {
                EAN4002448065111.SetActive(false);
                EAN4002448065111_2.SetActive(false);
            }
            if (responsetext.Contains("4010355592118"))
            {
                EAN4010355592118.SetActive(true);
                EAN4010355592118_2.SetActive(true);
            }
            else
            {
                EAN4010355592118.SetActive(false);
                EAN4010355592118_2.SetActive(false);
            }
            if (responsetext.Contains("4058172509377"))
            {
                EAN4058172509377.SetActive(true);
            }
            else
            {
                EAN4058172509377.SetActive(false);
            }
            if (responsetext.Contains("4058172179648"))
            {
                EAN4058172179648.SetActive(true);
                EAN4058172179648_2.SetActive(true);
            }
            else
            {
                EAN4058172179648.SetActive(false);
                EAN4058172179648_2.SetActive(false);
            }
            if (responsetext.Contains("4058172051845"))
            {
                EAN4058172051845.SetActive(true);
            }
            else
            {
                EAN4058172051845.SetActive(false);
            }
            if (responsetext.Contains("4058172051869"))
            {
                EAN4058172051869.SetActive(true);
            }
            else
            {
                EAN4058172051869.SetActive(false);
            }
            if (responsetext.Contains("4058172509117"))
            {
                EAN4058172509117.SetActive(true);
            }
            else
            {
                EAN4058172509117.SetActive(false);
            }
            if (responsetext.Contains("4058172491306"))
            {
                EAN4058172491306.SetActive(true);
                EAN4058172491306_2.SetActive(true);
                EAN4058172491306_3.SetActive(true);
                EAN4058172491306_4.SetActive(true);
            }
            else
            {
                EAN4058172491306.SetActive(false);
                EAN4058172491306_2.SetActive(false);
                EAN4058172491306_3.SetActive(false);
                EAN4058172491306_4.SetActive(false);
            }
            if (responsetext.Contains("4058172509681"))
            {
                EAN4058172509681.SetActive(true);
                EAN4058172509681_2.SetActive(true);
            }
            else
            {
                EAN4058172509681.SetActive(false);
                EAN4058172509681_2.SetActive(false);
            }
            if (responsetext.Contains("4058172453151"))
            {
                EAN4058172453151.SetActive(true);
            }
            else
            {
                EAN4058172453151.SetActive(false);
            }
            if (responsetext.Contains("4058172508851"))
            {
                EAN4058172508851.SetActive(true);
            }
            else
            {
                EAN4058172508851.SetActive(false);
            }
            if (responsetext.Contains("4058172470080"))
            {
                EAN4058172470080.SetActive(true);
                EAN4058172470080_2.SetActive(true);
            }
            else
            {
                EAN4058172470080.SetActive(false);
                EAN4058172470080_2.SetActive(false);
            }
            if (responsetext.Contains("4058172470066"))
            {
                EAN4058172470066.SetActive(true);
                EAN4058172470066_2.SetActive(true);
            }
            else
            {
                EAN4058172470066.SetActive(false);
                EAN4058172470066_2.SetActive(false);
            }
            if (responsetext.Contains("8710908769085"))
            {
                EAN8710908769085.SetActive(true);
                EAN8710908769085_2.SetActive(true);
            }
            else
            {
                EAN8710908769085.SetActive(false);
                EAN8710908769085_2.SetActive(false);
            }
            if (responsetext.Contains("8710908778148"))
            {
                EAN8710908778148.SetActive(true);
                EAN8710908778148_2.SetActive(true);
                EAN8710908778148_3.SetActive(true);
            }
            else
            {
                EAN8710908778148.SetActive(false);
                EAN8710908778148_2.SetActive(false);
                EAN8710908778148_3.SetActive(false);
            }

        }

    }

    
}
