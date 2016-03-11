using UnityEngine;
using System.Collections;

public class RoadController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed = 3f;
    private Transform _transform;
    private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();

		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(0, this.speed);
        this._transform.position = this._currentPosition;

		// Check bottom boundary
		if (_currentPosition.y <= -186) {
			this._Reset();
		}
	}

	private void _Reset() {
        this._transform.position = new Vector2(0, 186f);

	}
}
