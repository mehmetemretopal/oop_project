/*
 * NAME SURNAME : MEHMET EMRE TOPAL
 * NUMBER : B221202075
 * HONOR CODE
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopdeneme
{
    class Polygon : Point2D
    {
        public void Center(int x, int y)
        {
            Point2D.X = x;
            Point2D.Y = y;
        }

        public static int length { get; set; }
        public static int numberOfEdges { get; set; }
        public Polygon()
        {

        }
        public Polygon(int length, int x, int y)
        {
            Center(x, y);

        }
        public static void calculateEdgeCoordinates()
        {
            Random rn = new Random();
            length = rn.Next(3, 9);
            numberOfEdges = rn.Next(3, 10);

            // Çokgenin yarıçapını hesapla
            double r = length / (2 * Math.Tan(Math.PI / numberOfEdges));
            double new_r = Math.Round(r, 3);

            // Her bir köşe için açı artışını hesapla (2π/n)
            double angleStep = 2 * Math.PI / numberOfEdges;

            // İlk köşe için rastgele bir başlangıç açısı belirle (0-2π arası)
            double startAngle = rn.NextDouble() * 2 * Math.PI;


            // Tüm köşe noktalarını hesapla
            for (int i = 0; i < numberOfEdges; i++)
            {
                // Her köşe için açıyı hesapla
                double currentAngle = startAngle + (i * angleStep);

                // Köşe koordinatlarını hesapla
                double x_coo_edge = r * Math.Cos(currentAngle);
                double y_coo_edge = r * Math.Sin(currentAngle);

                // Merkez noktasına göre offset ekle
                x_coo_edge += X;
                y_coo_edge += Y;


            }


        }

    }
}
