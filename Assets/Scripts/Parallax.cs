using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note: this only parallaxes in the x-direction, but can be modified to parallax in the y-direction if desired later

public class Parallax : MonoBehaviour
{
    public Transform[] backgrounds;     // array of backgrounds/foregrounds
    private float[] parallaxScales;     // to allow different proportions of movement of the camera
    public float smoothing = 1f;        // how smooth the parallax is, should be above 0

    private Transform cam;              // main camera reference
    private Vector3 previousCamPos;     // position of camera in previous frame

    // called before start
    void Awake()
    {
        // set up camera reference
        cam = Camera.main.transform;
    }

    // initialization
    void Start()
    {
        // previous frame had the current frame's camera position
        previousCamPos = cam.position;

        // assign corresponding parallaxScales
        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    // called once per frame
    void Update()
    {
        // loop through the backgrounds
        for (int i = 0; i < backgrounds.Length; i++)
        {
            // parallax is opposite of camera's movement, multiplied by scale
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

            // target x-position is current position plus parallax x
            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            // create target position vector
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            // fade using lerp
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        // set previousCamPos to current position
        previousCamPos = cam.position;
    }
}
