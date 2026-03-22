using System;

class Epidem 
{
    public static int Epidemic(int tm, int n, int s0, int i0, double b, double a) 
    {
        double dt = (double)tm / n;
      
        double s = s0;
        double i = i0;
        double r = 0;
        double maxI = i;
        
        for (int k = 0; k < n; k++)
        {
            double nextS = s - dt * b * s * i;
            double nextI = i + dt * (b * s * i - a * i);
            double nextR = r + dt * a * i;
          
            if (nextI > i) 
                maxI = nextI;
          
            s = nextS;
            i = nextI;
            r = nextR;
        }
        
        return (int)maxI;
    }
}