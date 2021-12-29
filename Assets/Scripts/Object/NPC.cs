/*
 * Author: Isaac
 * Description: Controls NPC interaction
 */

using UnityEngine;

public class NPC : MonoBehaviour
{
    GameObject prompt;

    Transform speech;

    int speechNumber = 0;

    bool inRange = false;
    bool talking = false;

    void Start()
    {
        prompt = transform.GetChild(0).gameObject;
        speech = transform.GetChild(1);

        prompt.SetActive(false);

        foreach (Transform t in speech.transform)
        {
            t.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (inRange && !talking)
            {
                prompt.SetActive(false);

                speech.GetChild(0).gameObject.SetActive(true);

                talking = true;
            }

            else if (talking)
            {
                speech.GetChild(speechNumber++).gameObject.SetActive(false);

                if (speechNumber < speech.childCount)
                {
                    speech.GetChild(speechNumber).gameObject.SetActive(true);
                }

                else
                {
                    speechNumber = 0;
                    talking = false;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!talking)
        {
            prompt.SetActive(true);

            inRange = true;
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        prompt.SetActive(false);

        inRange = false;
    }
}
