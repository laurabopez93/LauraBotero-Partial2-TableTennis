using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {


       
	}
	
	// Update is called once per frame
	void Update () {
        // Esta instruccion mueve el Gameobject hacia su derecha 
        // this.transform.Translate(Vector3.right);

        if (Input.GetKey(KeyCode.LeftArrow)) {
            //Esta isntruccion rota el Gameobject con respecto a su eje Y
            this.transform.Translate(Vector3.left);}

        if (Input.GetKey(KeyCode.RightArrow)) {
                //Esta isntruccion rota el Gameobject con respecto a su eje Y
            this.transform.Translate(Vector3.right);}

        if (Input.GetKey(KeyCode.UpArrow)){
            //Esta isntruccion rota el Gameobject con respecto a su eje Y
            this.transform.Translate(Vector3.up);}

        if (Input.GetKey(KeyCode.X)){

            //Esta isntruccion rota el Gameobject con respecto a su eje Y
            this.transform.Rotate(Vector3.right); }

        if (Input.GetKey(KeyCode.Y))  {
            //Esta isntruccion rota el Gameobject con respecto a su eje Y
            this.transform.Rotate(Vector3.up); }
        
        if (Input.GetKey(KeyCode.Z)) {
            //Esta isntruccion rota el Gameobject con respecto a su eje Y
            this.transform.Rotate(Vector3.forward);}
        }
	}
