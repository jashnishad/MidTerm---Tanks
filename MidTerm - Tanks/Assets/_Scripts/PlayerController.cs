using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public float speed = 3f;
	public Boundary boundary;
   


	// get a reference to the camera to make mouse input work
	public Camera camera; 
	
	// PRIVATE INSTANCE VARIABLES
	//private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
    private float _playerInput;
	private Transform _transform;
	private Vector2 _currentPosition;
	
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();

	}

	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Horizontal");
        // if player input is positive move right 
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        // if player input is negative move left 
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }


            // movement by mouse
            //Vector2 mousePosition = Input.mousePosition;
            //this._newPosition.x = this.camera.ScreenToWorldPoint (mousePosition).x;

            this._BoundaryCheck();
        this._transform.position = this._currentPosition;

            //gameObject.GetComponent<Transform>().position = this._newPosition;
        }
	

    //private void _CheckInput()
    //{
        
    //}
	

	private void _BoundaryCheck() {
		if (this._currentPosition.x < this.boundary.xMin) {
			this._currentPosition.x = this.boundary.xMin;
		}

		if (this._currentPosition.x > this.boundary.xMax) {
			this._currentPosition.x = this.boundary.xMax;
		}
	}
}
