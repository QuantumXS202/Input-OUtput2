using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dpad : MonoBehaviour
{

    public float DraaiSpeedHorizontal;
    public float DraaiSpeedVertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(DraaiSpeedVertical, 0f, DraaiSpeedHorizontal));


        if (Input.GetKey(KeyCode.RightArrow))
        {
            DraaiSpeedHorizontal += 0.005f;
            Debug.Log("Ik wordt ingedurkt");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            DraaiSpeedHorizontal -= 0.005f;
            Debug.Log("Ik wordt ingedurkt");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            DraaiSpeedVertical -= 0.005f;
            Debug.Log("Ik wordt ingedurkt");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            DraaiSpeedVertical += 0.005f;
            Debug.Log("Ik wordt ingedurkt");
        }



    }
}
