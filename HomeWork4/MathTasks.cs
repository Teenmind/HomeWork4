using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class MathTasks
    {
        public static double DistanseOfShotDegree( int degree, double speed)
        {
            double dist = 0;
            dist = (speed * speed * Math.Sin(2*degree)) / 9.8;
            return dist;
        }

        public static double DistanseOfShotRad(double rad, double speed)
        {
            double dist = 0; 
            dist = (speed * speed * Math.Sin(rad*Math.PI/90)) / 9.8;
            return dist;
        }

        public static double DistanseBetweenCars(double v1, double v2, double s, double t)
        {
            if (v1 < 0 || v2 < 0 || s < 0 || t < 0)
                throw new ArgumentOutOfRangeException();

            double l = 0;
            l = s + (v1+v2)*t;
            return l;
        }

        public static bool InsideCrossedArea(double x, double y)
        {
            bool flag = false;

            double x1 = -1;
            double y1 = 0;
            double x2 = -2;
            double y2 = 2;
            double x3 = 0;
            double y3 = 0;

            double s = 0;
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            
            s = 1 / 2 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
            s1 = 1 / 2 * Math.Abs((x2 - x1) * (y - y1) - (x - x1) * (y2 - y1));
            s2 = 1 / 2 * Math.Abs((x - x1) * (y3 - y1) - (x3 - x1) * (y - y1));
            s3 = 1 / 2 * Math.Abs((x2 - x) * (y3 - y) - (x3 - x) * (y2 - y));
            if (s == s1 + s2 + s3)
                flag = true;
            else
            {
                x1 = 1;
                y1 = 0;
                x2 = 2;
                y2 = 2;
                x3 = 0;
                y3 = 0;

                s = 1 / 2 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
                s1 = 1 / 2 * Math.Abs((x2 - x1) * (y - y1) - (x - x1) * (y2 - y1));
                s2 = 1 / 2 * Math.Abs((x - x1) * (y3 - y1) - (x3 - x1) * (y - y1));
                s3 = 1 / 2 * Math.Abs((x2 - x) * (y3 - y) - (x3 - x) * (y2 - y));

                if (s == s1 + s2 + s3)
                    flag = true;
                else
                {
                    x1 = 1;
                    y1 = 0;
                    x2 = 0;
                    y2 = -1;
                    x3 = -1;
                    y3 = 0;

                    s = 1 / 2 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
                    s1 = 1 / 2 * Math.Abs((x2 - x1) * (y - y1) - (x - x1) * (y2 - y1));
                    s2 = 1 / 2 * Math.Abs((x - x1) * (y3 - y1) - (x3 - x1) * (y - y1));
                    s3 = 1 / 2 * Math.Abs((x2 - x) * (y3 - y) - (x3 - x) * (y2 - y));

                    if (s == s1 + s2 + s3)
                        flag = true;
                }
            }

            return flag;
        }

        public static double CalculateExpression(double x)
        {
            return (6 * Math.Log10(Math.Sqrt(Math.Pow(Math.E, x + 1) + 2 * Math.Pow(Math.E, x) * Math.Cos(x))) / Math.Log10(x - Math.Pow(Math.E, x + 1) * Math.Sin(x)) + Math.Abs(Math.Cos(x)/Math.Pow(Math.E, Math.Sin(x))));
        }

    }
}
