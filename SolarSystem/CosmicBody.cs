using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    abstract class CosmicBody
    {
        protected float x { get; set; }
        protected float y { get; set; }
        protected float m { get; set; }
        protected float v { get; set; }
        protected float a { get; set; }
        protected float vx { get; set; }
        protected float vy { get; set; } 
        protected float ax { get; set; }
        protected float ay { get; set; }
        protected float x0 { get; set; }
        protected float y0 { get; set; }
        protected float r { get; set; }
        
        public abstract void BodyPosCalc(out float X, out float Y);
    }
}
