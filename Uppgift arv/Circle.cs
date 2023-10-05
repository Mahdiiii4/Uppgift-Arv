using Uppgift_Arv;

namespace Uppgift_arv
{
    public class Circle : IShape
    {
        int radien;

        public Circle(int radie)
        {
            radien = radie;
        }

        public int Area()
        {
            int area = (int)Math.PI*(radien*radien);
            return area;
        }
        public int Circumferance()
        {
            int circumferance = (int)(2 * radien * Math.PI);
            return circumferance;
        }
    }
}