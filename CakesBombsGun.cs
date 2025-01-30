using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakesBombsGun : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ActiveCake;
    //public Button rowBtnAc;
    [SerializeField] public int cakeBtn;
    public bool activeS;
    public Text QualityCakeTxt;
    //public GameObject adjacentMarker;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Active1()
    {
        ActiveCake = true;
    }
    public void Active2()
    {
        ActiveCake = true;

        cakeBtn = PlayerPrefs.GetInt("numCakshow");

        Debug.Log("true");
        //StartCoroutine(RowAnimAct());

        //isTomatBombu = true;

        Debug.Log("falsiki");

        int numberCakeToShow = cakeBtn;


        QualityCakeTxt.text = "" + numberCakeToShow;
        PlayerPrefs.SetInt("numCakshow", numberCakeToShow);
        Debug.Log("decr tomat");

        if (numberCakeToShow <= 0)
        {
            numberCakeToShow = 0;

            PlayerPrefs.SetInt("numCakshow", numberCakeToShow);

        }
    }
    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cursorPos = CameraScreenToWorldPoint(Input.mousePosition);
            transform.Position = new Vector2(cursorPos.x, cursorPos.y);
            GameObject marker = Instantiate(adjacentMarker, transform.position, Quaternion.identity);
            marker.transform.parent = newObject.transform;
        }*/
        cakeBtn = PlayerPrefs.GetInt("numCakshow");
        /*if (cakeBtn <= 0)
        {
            activeCake = false;
        }*/
    }
}
