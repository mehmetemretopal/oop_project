/*
 * NAME SURNAME : MEHMET EMRE TOPAL
 * NUMBER : B221202075
 * HONOR CODE
 */
using System;

public class Point2D
{
    public static int X { get; set; }
    public static int Y { get; set; }

    public static double r { get; set; }
    public static double radyan { get; set; }

    public static double alpha { get; set; }

    public Point2D()
    {
        Random random = new Random();// creating a random number generator
        X = random.Next(5, 10);
        Y = random.Next(5, 15);
        r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));// calculating the distance from the origin

    }
    public static (int X, int Y) printCoordinate()
    {

        return (X, Y);

    }
    public static void calculatePolarCoordinates()
    {
        double radyan = Math.Atan(Y / X);
        double alpha = radyan * (180.0 / Math.PI);
        double new_r = Math.Round(r, 2);
        double new_alpha = Math.Round(alpha, 2);

    }
    // This method calculates the caartesian coordinates of the point
    public static void calculateCartesianCoordinates()
    {
        double radyan = Math.Atan(Y / X);
        double new_radyan = Math.Round(radyan, 3);
        double alpha = radyan * (180.0 / Math.PI);
        double x = (r * Math.Cos(alpha));
        double new_x = Math.Round(x, 2);// rounding to 2 decimal places
        double y = (r * Math.Sin(alpha));
        double new_y = Math.Round(y, 2);// rounding to 2 decimal places
    }

    public string printPolarCoordinates()
    {
        return String.Format("P(r={0:F2}, θ={1:F2}°)", r, alpha);
    }
}