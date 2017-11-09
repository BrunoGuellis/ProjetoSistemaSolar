using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerLava : MonoBehaviour {
    float timeleft;
    public GameObject go;
    public GameObject chaozera;
    public GameObject lavera;
    public GameObject bumper;
    public GameObject bumperd;
    public GameObject bumpert;
    public GameObject bumperq;
    public GameObject bumperc;
    public Text tempo;
    public int ponto =0;
    // Use this for initialization
    void Start () {
        timeleft = 10f;
	}


    // Update is called once per frame
    void Update () {
        timeleft -= Time.deltaTime;
        if (timeleft > 0)
            {
            
            tempo.text = timeleft.ToString()+"                    |                    "+ponto;
            }
        else {
            Debug.Log(timeleft);
            chaozera.SetActive(false);
            lavera.SetActive(true);
            if (timeleft < -3)
            {
                chaozera.SetActive(true);
                lavera.SetActive(false);
                timeleft = 10;
                ponto++;
                bumper.transform.position = new Vector3(Random.Range(-16, 16),1, Random.Range(-16, 16));
                bumperd.transform.position = new Vector3(Random.Range(-16, 16),1, Random.Range(-16, 16));
                bumpert.transform.position = new Vector3(Random.Range(-16, 16),1, Random.Range(-16, 16));
                bumperq.transform.position = new Vector3(Random.Range(-16, 16),1, Random.Range(-16, 16));
                bumperc.transform.position = new Vector3(Random.Range(-16, 16),1, Random.Range(-16, 16));
                

            }
        }

        
    }
}
