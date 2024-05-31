using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSystem : MonoBehaviour
{
    [SerializeField] GameObject Earth;
    [SerializeField] GameObject Moon;
    [SerializeField] GameObject Rocket;

    Vector3 MoonAcceleration;
    Vector3 MoonDirection;

    Vector3 RocketAcceleration = Vector3.zero;
    Vector3 RocketVelocity = Vector3.zero;

    float MoonSpeed;
    Vector3 MoonVelocity;

    //enum State { place, grounded, aireborne};
    //State state= State.place;

    float MoonRotation;
    float EarthRotation;

    //float Radius, Theta, Phi, dTheta, dPhi;

    void Start()
    {
        //Radius = Earth.transform.localScale.x / 2;
        
        //Phi = Mathf.PI / 2f; // elevation
        //Theta = 0f; // azimuthal angle

        //dTheta = 0.01f;
        //dPhi = 0.01f;

        MoonVelocity = new Vector3(0, 0, -1.2f);
    }

    void Update()
    {
        Vector3 differenceVector = Earth.transform.position - Moon.transform.position;
        float distance = differenceVector.magnitude;

        MoonDirection = differenceVector.normalized;
        MoonSpeed = 5 /(distance*distance);
        MoonAcceleration = MoonSpeed * MoonDirection;
        MoonVelocity += MoonAcceleration * Time.deltaTime;
        Moon.transform.position += MoonVelocity * Time.deltaTime;

        //RocketAcceleration = new Vector3 (0, 0, 0);
        RocketVelocity = RocketAcceleration * Time.deltaTime;
        Rocket.transform.position += RocketVelocity;


        Earth.transform.Rotate(0, 0, EarthRotation);


        /*
        if (state == State.place)
        {
            EarthRotation = 0f;
            MoonRotation = 0f;
            Rocket.transform.position = ConvertSphericIntoCartisian();
            Vector3 directionFromCenter = (Rocket.transform.position - Earth.transform.position).normalized;
            Rocket.transform.rotation = Quaternion.LookRotation(directionFromCenter);
            Rocket.transform.RotateAround(Earth.transform.position, Vector3.up, -0.2f);
            Phi -= Input.GetAxis("Vertical") * dPhi;
            Theta += Input.GetAxis("Horizontal") * dTheta;

            RocketAcceleration = Vector3.zero;
            RocketVelocity = Vector3.zero;

            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                state = State.grounded;
            }
        }

        if(state == State.grounded)
        {
            //MoonVelocity = new Vector3(0, 0, -0.8f);
            //EarthRotation = 2f;
            MoonRotation = 2f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = State.aireborne;
            }
        }

        if (state == State.aireborne)
        {
            //accelerationRocket
            RocketVelocity = Rocket.transform.forward * 5f;
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = State.place;
            }
        }

        


    Vector3 ConvertSphericIntoCartisian(){
         float xCartesian = Radius * Mathf.Sin(Phi) * Mathf.Cos(Theta);
         float yCartesian = Radius * Mathf.Cos(Phi);
         float zCartesian = Radius * Mathf.Sin(Phi) * Mathf.Sin(Theta);
            
         return new Vector3(xCartesian, yCartesian, zCartesian);
        }
        */
    }

}
