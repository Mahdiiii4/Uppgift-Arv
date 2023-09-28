namespace Uppgift_arv
{
    public class Triangle : IShape
    {
        int width;
        int height;
        public Triangle(int höjd, int bredd)
        {
        }

        public int Area()
        {
            int area = (width*height)/2;
            return area;
        }
        public int Circumferance()
        {
            int circumferance = (int)Math.Sqrt((width*width)+(height*height))+height+width;
            return circumferance;
        }
    }
}