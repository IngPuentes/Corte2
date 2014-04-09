using UnityEngine;
using System.Collections;

public class tallerGUI : MonoBehaviour {
	public string textActividad = "";
	public string agregaActividad = "";
	public string textTarea="";
	public string agregaTarea="";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.Label(new Rect(0,0,100,30),"Crear Actividad:");
		textActividad= GUI.TextField (new Rect (0, 30, 150, 30), textActividad);
		agregaActividad = GUI.TextArea (new Rect (200, 0, 200, 200), agregaActividad);
		if (GUI.Button (new Rect (80, 90, 60, 30), "Agregar")) {
			if(textActividad!=""){
			agregaActividad="\n"+textActividad+agregaActividad;
			textActividad="";
			}
		}

		GUI.Label (new Rect (0, 230, 100, 30), "Crear Tareas:");
		textTarea=GUI.TextField (new Rect (0, 260, 150, 30), textTarea);
		agregaTarea = GUI.TextArea (new Rect (200, 230, 200, 200), agregaTarea);
		if (GUI.Button (new Rect (80, 320, 60, 30), "Agregar")) {
			if(textTarea!=""){
				agregaTarea=agregaTarea+textTarea+"\n";
				textTarea="";
			}
		}
		}
}
