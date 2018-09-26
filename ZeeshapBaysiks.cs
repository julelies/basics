using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeeshapBaysiks : MonoBehaviour
{
	int player = 1;
	string participant;
	bool x;
	bool y;

	// Use this for initialization
	void Start ()
	{
		//Variablen deklariert
		float score;
		char category;
		byte none;
		long none1;
		short none3;
		double none4;

		addOne ();
		setName ();
		testbool ();
		diwaid ();
		multivitamin ();
		modulose ();
		glaich ();
		veaglaich ();
		int test = getNumber ();
		Debug.Log (test);
		Debug.Log ("-");
		Debug.Log (getNumber ());

	}

	void veaglaich ()
	{
		int e = 6;
		int c = 3;
		Debug.Log ("veaglaich" + (e != c));
	}

	void glaich ()
	{
		int a = 8;
		int b = 8;
		Debug.Log ("glaich" + (a == b));
	}

	void modulose ()
	{

		float z = 7;
		float o = 4;
		Debug.Log ("modulose" + (z % o));
	}

	void multivitamin ()
	{
		double c = 9;
		double e = 5;

		Debug.Log ("multivitamin" + (c * e));
	}

	void diwaid ()
	{
		float a = 4;
		float b = 5;
		Debug.Log ("diwaid " + (a / b));
	}


	void testbool ()
	{
		x = true;
		y = true;

		Debug.Log ("w oder f" + (x & y));
		Debug.Log ("Bedingt oder f" + (x && y));

	}



	void setName ()
	{
		participant = "Max Musterman";
		Debug.Log (participant);
	}



	void addOne ()
	{
		player = player + 1;
		Debug.Log ("player = " + player);


	}

	int getNumber ()
	{

		return 5;
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
