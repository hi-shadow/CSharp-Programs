class box
{
    double height,width,depth;
    box(double h,double w,double d)
    {
        height=h;
        width=w;
        depth=d;
    }
    double volume()
    {
        return height*width*depth;
    }
}
class constructorDemo2 
{  
    public static void main(String[] args)
    {
         double vol;
         box b1=new box(10,20,15);
         box b2=new box(1,2,5);
         vol=b1.volume();
         System.out.println("b1 value="+vol);
         vol=b2.volume();
         System.out.println("b2 value="+vol);    
    }
}
