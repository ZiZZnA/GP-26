using Unity.VectorGraphics;
using UnityEngine;

namespace AA0000
{
    public class Bottle : MonoBehaviour
    {
        public Material bottleMaterial;
        public string bottleContents;
        [Range(0.0f, 1.0f)]
        public float liquidAmount;

        private float minLiquidCapacity = 0.0f;
        private float maxLiquidCapacity = 1.0f;


        public bool isCapOn = true;



        // Update is called once per frame
        void Update()
        {

        }

        public void ChangeLiquidAmount(float changeAmount)
        {
            //TODO: Change the amount of liquid and safeguard against going below or over the capacity of the bottle
        }

    }
}