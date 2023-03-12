using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace scropts
{
    public class Triggers : MonoBehaviour
    {
        public GameObject player;
        public Transform spawn;
        private ProgrammerGame game;
        // Start is called before the first frame update
        void Start()
        {
            player.transform.position = spawn.position;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.transform.position = spawn.position;
        }
    }
}

