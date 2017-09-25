using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {

    public Vector3 torque;
    public float torqueTime;

    private Rigidbody rigidBody;

    void OnEnable () {
        rigidBody = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (torqueTime >= 0f) {
            rigidBody.AddTorque(torque);
            torqueTime -= Time.deltaTime;
        }
	}
}
