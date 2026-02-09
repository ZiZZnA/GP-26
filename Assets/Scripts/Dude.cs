using UnityEngine;

namespace AH2724
{
    public class Dude : MonoBehaviour
    {
        [SerializeField]
        private Material dudeMaterial;
        [SerializeField]
        private PhysicsMaterial dudePhysicsMaterial;
        [SerializeField]
        private Transform dudeLocation;
        [SerializeField]
        private string dudeName;
        [SerializeField]
        private float dudeHeight;
        [SerializeField]
        private float dudeWidth;



        public bool isADude = true;
        public bool isABro = false;



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}