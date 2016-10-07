using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Planet : CosmicBody
    {
        public Planet (float X0, float Y0, float X, float Y, float M, float R, float VX, float VY, float AX, float AY)
        {
            x0=X0;
            y0 = Y0;
            x=X;
            y=Y;
            m=M;
            r=R;
            vx=VX;
            vy=VY;
            ax=AX;
            ay=AY;
        }

        public override void BodyPosCalc(out float X, out float Y)
        {
            r = (float)Math.Sqrt(Math.Pow((x - x0),2f) + Math.Pow((y - y0), 2));
            ax = (float)(m * (x0 - x) / Math.Pow(r, 3));
            ay = (float)(m * (y0 - y) / Math.Pow(r ,3));
            vx += ax;
            vy += ay;
            x += vx;
            y += vy;
            X = x;
            Y = y;
        }
    }
}
