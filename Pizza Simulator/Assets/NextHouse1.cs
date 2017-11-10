using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextHouse1 : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	public bool isCurrentWaypoint;
	public NextHouse2 next;
	public Collider coll;
	public GameObject House;

   void Start()
   {
	   obj1.SetActive (false);
           obj2.SetActive (false);
   }

   // Toggle the Object's visibility if this house is the current waypoint.
   void Update()
   {
			if (isCurrentWaypoint == true)
			{
				obj1.SetActive (true);
		                obj2.SetActive (true);
			} else if (isCurrentWaypoint == false){
				obj1.SetActive (false);
		                obj2.SetActive (false);
			}
			if(Input.GetKeyDown(KeyCode.Escape) == true)
			{
			   	Application.Quit();
			}
   }

   void OnTriggerEnter(Collider coll) {
		 Debug.Log("Collision Detected");
		 if(coll.gameObject.tag == "Player")
     {
         //add the code you want to execute on collision
         //to access the Ball gameObject use : col.gameObject
				 isCurrentWaypoint = false;
			   next.isCurrentWaypoint = true;
     }
		 print(" Worked");
   }

}
