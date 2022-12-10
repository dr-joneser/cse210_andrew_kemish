using Raylib_cs;
using System.Numerics;

abstract class Drawing{
    virtual public void Draw(){

    }
}

public class LevelOneTopPlatforms {
    public List<Rectangle> TopHalfList = new List<Rectangle>();
    public void CreateTopList(){
        int PlatformHeight = 5;
        int PlatformLength = 100;
       Rectangle one = new   Rectangle(160,5,PlatformLength, 400);
       Rectangle two = new   Rectangle(300,275,PlatformLength, PlatformHeight); 
       Rectangle three = new Rectangle(50,450,PlatformLength, PlatformHeight); 
       Rectangle four = new  Rectangle(350,550,PlatformLength, PlatformHeight); 
       Rectangle five = new  Rectangle(180,714,PlatformLength, PlatformHeight); 
       TopHalfList.Add(one);
       TopHalfList.Add(two);
       TopHalfList.Add(three);
       TopHalfList.Add(four);
       TopHalfList.Add(five);
    }
    // override public void Draw() {
    //     foreach( var obj in TopHalfList){
    //         Raylib.DrawRectangle((int)obj.x,(int)obj.y+5,(int)obj.width,(int)obj.height);
    //     }
    // }
}

public class LevelOneBottomPlatforms: LevelOneTopPlatforms{
    public List<Rectangle>  BottomHalfList = new List<Rectangle>();
    public void CreateBottomList(){
        foreach (var obj in TopHalfList){
            Rectangle BottomHalf = new Rectangle((int)obj.x,(int)obj.y+5,(int)obj.width,(int)obj.height);
            BottomHalfList.Add(BottomHalf);
        }
    }
    // override public void Draw() {
    //     foreach( var obj in TopHalfList){
    //         Raylib.DrawRectangle((int)obj.x,(int)obj.y+5,(int)obj.width,(int)obj.height);
    //     }
    }

// class LevelTwoPlatforms: DrawPlatform{
//         override public void Draw() {
//             Raylib.DrawRectangle(10, 75, 5,100, Color.GREEN);
//             Raylib.DrawRectangle(10, 10, 5,100, Color.GREEN);
//         }
// }


