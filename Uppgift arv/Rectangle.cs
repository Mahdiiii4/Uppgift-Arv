namespace Uppgift_arv
{
    public class Rectangle : IShape
    {
        int width;
        int height;
        public Rectangle(int höjd, int bredd)
        {
        }

        public int Area()
        {
            int area = width*height;
            return area;
        }
        public int Circumferance()
        {
            int circumferance = (width*2)+(height*2);
            return circumferance;
        }
    }
}