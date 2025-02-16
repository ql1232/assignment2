using UnityEngine;
using UnityEngine.Events;

 public class BallController : MonoBehaviour
 {
[SerializeField] private Transform ballAnchor;

 [SerializeField] private bool clicked = false;
 [SerializeField] private InputManager inputManager;

	private Rigidbody ballRB;
 	void Start()
 	{
 	//Grabbing a reference to RigidBody
 	ballRB = GetComponent<Rigidbody>();

	 // Add a listener to the OnSpacePressed event.
 	// When the space key is pressed the
 	// LaunchBall method will be called.
 		inputManager.OnSpacePressed.AddListener(LaunchBall);
	transform.parent = ballAnchor;
	 transform.localPosition = Vector3.zero;
	ballRB.isKinematic=true;
	 }


	private void LaunchBall()

	{
	if(!clicked){
clicked=true;
transform.parent = null; ballRB.isKinematic=false;
ballRB.AddForce(transform.forward * 5, ForceMode.Impulse);
}
	}
}
