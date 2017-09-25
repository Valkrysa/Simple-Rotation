using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ShowStats : MonoBehaviour {

    private Rigidbody rigidBody;

	// Use this for initialization
	void OnEnable () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(name + " inertia tensor " + rigidBody.inertiaTensor);
        Debug.Log(name + " COM " + rigidBody.centerOfMass);
	}
}

/*
1. With no net force, velocity remains constant.
2. Force = mass * acceleration
3. Every force has an equal and opposite force.

1. With no net torque, angular velocity remains constant.
2. Torque = inertia tensor * angular acceleration
3. Every torque has an equal and opposite torque.
*/
