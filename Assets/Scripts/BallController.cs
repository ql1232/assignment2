using UnityEngine;
using UnityEngine.Events;

 public class BallController : MonoBehaviour
 {
 [SerializeField] private float force = 50f;
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
	 }


	private void LaunchBall()

	{
	ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
	}
}
