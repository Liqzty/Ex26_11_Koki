using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        private float width; //幅
        private float height;//高さ
        public Triangle(float w, float h)
        {
            this.width = w;
            this.height = h;
        }
        public float GetSurface()
        {
            return (width * height / 2);//面積
        }
    }
}
