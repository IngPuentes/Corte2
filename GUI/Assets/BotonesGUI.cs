using UnityEngine;
using System.Collections;

public class BotonesGUI : MonoBehaviour {

	float r = 0.0f;
	float g = 0.0f;
	float b = 0.0f;
	GameObject cube1;
	GameObject esfera1;
	GameObject capsula1;
	GameObject plano1;
	public GUISkin customSkin;
	void OnGUI () {
		GUI.skin = customSkin;
		GUI.Label (new Rect (260, 85, 100, 100), "ROJO");
		GUI.Label (new Rect (260, 115, 100, 100), "VERDE");
		GUI.Label (new Rect (260, 145, 100, 100), "AZUL");

		r = GUI.HorizontalSlider (new Rect (0,90,250,30),r, 0.0f, 1.0f);
		g = GUI.HorizontalSlider (new Rect (0,120,250,30),g, 0.0f, 1.0f);
		b = GUI.HorizontalSlider (new Rect (0,150,250,30),b, 0.0f, 1.0f);

		if (GUI.Button (new Rect (0, 0, 100, 30), "Crear Cubo")) {
			Destroy(esfera1,0.1f);
			Destroy(capsula1,0.1f);
			Destroy(plano1,0.1f);

			cube1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube1.transform.position = new Vector3 (0, 0, 0);
			cube1.transform.localScale = new Vector3 (2, 2, 2);
			cube1.transform.rotation = Quaternion.Euler (0, 0, 0);
			cube1.renderer.material.color = new Color (r, g, b, 250f);				
				

				}

		if (GUI.Button (new Rect (0,35,100,30), "Crear esfera")) {
			Destroy(capsula1,0.1f);
			Destroy(plano1,0.1f);
			Destroy(cube1,0.1F);
			esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			esfera1.transform.position = new Vector3(0, 0, 0);
			esfera1.transform.localScale = new Vector3 (2,2,2);
			esfera1.transform.rotation = Quaternion.Euler (0,0,0);
			esfera1.renderer.material.color=new Color(r,g,b);
				

		}
		if (GUI.Button (new Rect (110,0,100,30), "Crear Capsula")) {
			Destroy(plano1,0.1f);
			Destroy(cube1,0.1F);
			Destroy(esfera1,0.1f);

			capsula1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			capsula1.transform.position = new Vector3(0, 0, 0);
			capsula1.transform.localScale = new Vector3 (2,2,2);
			capsula1.transform.rotation = Quaternion.Euler (0,0,0);
			capsula1.renderer.material.color=new Color(r,g,b);
				
		}
		if (GUI.Button (new Rect (110,35,100,30), "Crear Plano")) {
			Destroy(cube1,0.1F);
			Destroy(esfera1,0.1f);
			Destroy(capsula1,0.1f);

			plano1 = GameObject.CreatePrimitive(PrimitiveType.Plane);
			plano1.transform.position = new Vector3(0, 0, 0);
			plano1.transform.localScale = new Vector3 (1,1,1);
			plano1.transform.rotation = Quaternion.Euler (0,0,0);
			plano1.renderer.material.color=new Color(r,g,b);

		}
	}
	void Update(){
		if(cube1 != null)
		cube1.renderer.material.color=new Color(r,g,b);
		if(esfera1 != null)
		esfera1.renderer.material.color=new Color(r,g,b);
		if(capsula1 != null)
		 	capsula1.renderer.material.color=new Color(r,g,b);
		if (plano1 != null)
						plano1.renderer.material.color = new Color (r, g, b);
		}

}