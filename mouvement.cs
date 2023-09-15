using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    //public float vitesseRapide = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(Vector3.forward * 0.01f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.Translate(Vector3.back * 0.01f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(Vector3.up, -2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(Vector3.up, 2);
        } 
        //fonctionnalitee pour l'ajout de la vitesse , cela demande la fleche haut vers le haut et la lettre A

        if(Input.GetKey(KeyCode.UpArrow) & Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back* 10* Time.deltaTime);
        }   
        //fonctionnalitee pour l'ajout du saut, cela demande la fleche dirigee vers le haut et la lettre B
        
           if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.B))
        {
        transform.Translate(Vector3.up* 0.08f);
        }
}
}
