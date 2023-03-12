using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

namespace scropts
{
    public class ProgrammerGame : MonoBehaviour
    {
        public InputField stringPut;
        public GameObject HelpingMenu;
        public float timeSeconds;
        public GameObject Object;
        public GameObject End;
        public int speed;
        public int speedY;
        public int normalSpeed;
        private Rigidbody2D rg;
        // Start is called before the first frame update
        void Start()
        {
            rg = GetComponent<Rigidbody2D>();
            HelpingMenu.SetActive(false);
        }

        // Update is called once per frame
        private void Update()
        {
            rg.velocity = new Vector2(speed, speedY);
            if (stringPut.text == "Help")
            {
                HelpingMenu.SetActive(true);
            }
            else
            {
                HelpingMenu.SetActive(false);
            }

            if (stringPut.text == "Right")
            {
                speed = normalSpeed;
                Stoping();
            }
            else
            {
                Stop();
            }

            if (stringPut.text == "Left")
            {
                speed = -normalSpeed;
                Stoping();
            }

            if (stringPut.text == "Down")
            {
                speedY = -normalSpeed;
                Stoping();
            }

            if (stringPut.text == "Up")
            {
                speedY = normalSpeed;
                Stoping();
            }


            if (stringPut.text == "Stop")
            {
                speed = 0;
                speedY = 0;

            }
        }

        public void Close()
        {
            HelpingMenu.SetActive(false);
        }

        public void OneSecond()
        {
            timeSeconds = 1;
        }

        public void TwoSecond()
        {
            timeSeconds = 2;
        }

        public void ThreeSecond()
        {
            timeSeconds = 3;
        }

        IEnumerator Stoping()
        {
            yield return new WaitForSeconds(timeSeconds);
            Stop();
        }
        public void Stop()
        {
            speed = 0;
            speedY = 0;
        }

    }
}
