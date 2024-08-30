public class Fan{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    private  int speed = SLOW;
    private bool on = false;
    private double radius = 5;
    private string color = "blue";

public Fan(){}    

    public int getspeed(){
        return speed;
        
    }
    public void setspeed(int _speed){
       speed = _speed;
    }
     public bool getOn(){
       return on;
     }
     public void setOn(bool _on){
        on = _on;
     }

     public double getradius(){
        return radius;
     }
     public void setradius(double _radius){
        radius = _radius;
     }
     public string getcolor(){
        return color;
     }
     public void setcolor(string _color){
        color = _color;
     }
     public Fan(int _speed, bool _on, double  _radius, string _color){
    speed = _speed;
    on = _on;
    radius = _radius;
    color = _color;
}

     public string ToString(){
        if(on){
            return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
        }else{
            return $"Fan is off: Color = {color}, Radius = {radius}";
        }
     }
    
}