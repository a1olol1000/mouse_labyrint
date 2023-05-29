using System.Numerics;
using Raylib_cs;
int screenHeight = 800;
int screenWith = 800;
int x = 375;
int y = 275;
float milliSecund = 0;
int second = 0;
int minute = 0;
int hour = 0;
int draw = 0;
string milliSecunds = "0";
string seconds = "0";
string minutes = "0";
string hours = "0";
int speed = 3;
bool cheese = false;
int points = 0;
int startposX = x;
int startposY = y;
Raylib.InitWindow(screenHeight, screenWith, "Mouse in a rat maze");
Raylib.SetTargetFPS(60);

Color invs = new Color(255,255,255,255);
Texture2D mouse1 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint1.png");
Texture2D mouse2 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint2.png");
Texture2D mouse3 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint3.png");
Texture2D mouse4 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint4.png");
Texture2D mouse5 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint5.png");
Texture2D mouse6 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint6.png");
Texture2D mouse7 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint7.png");
Texture2D mouse8 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint8.png");
Texture2D mouse9 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint9.png");
Texture2D mouse10 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint10.png");
Texture2D mouse11 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint11.png");
Texture2D mouse12 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint12.png");
Texture2D mouse13 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint13.png");
Texture2D mouse14 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint14.png");
Texture2D mouse15 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint15.png");
Texture2D mouse16 = Raylib.LoadTexture(@"mouse_labyrint_character\mouse_labyrint16.png");
Texture2D wall1_1 = Raylib.LoadTexture(@"mouse_labyrint_map_asset\wall_1_1.png");
Texture2D the_cheese_is_a_lie = Raylib.LoadTexture("the_cheese_is_a_lie.png");
Texture2D mouseUpp = mouse1;
Texture2D mouseDown = mouse3;
Texture2D mouseRight = mouse5;
Texture2D mouseLeft = mouse7;
Texture2D theMouse = mouse1;
Texture2D mouseUppLeft = mouse9;
Texture2D mouseUppRight = mouse11;
Texture2D mouseDownRight = mouse13;
Texture2D mouseDownLeft = mouse15; 
 Raylib.SetMousePosition(startposX, startposY);
int[,] grid5 = {
    {1,1,1,1,1,1,1,1},
    {0,0,0,1,1,1,0,0},
    {1,1,0,1,1,1,0,1},
    {0,1,0,3,1,1,0,0},
    {1,1,1,1,2,0,0,1},
    {1,0,1,1,1,1,0,0},
    {0,0,1,0,0,0,1,1},
    {1,1,1,0,1,0,1,1,}};

    
   
    
    
    
    
    
 
        
        
    



    //0 = empty. 1 = wall. 2 = cheese. 3 = start pos.


while (!Raylib.WindowShouldClose())
{
  //logic
    //timer
  if (milliSecund < 1000)
  {
    milliSecund += 16.7f;
  }
  else if (milliSecund > 1000)
  {
    milliSecund = 0;
    second++;
  }
  if(second==60)
  {
    second=0;
    minute++;
  }
  if (minute==60)
  {
    minute=0;
    hour++;
  }

  if (draw < 5)
  {
    mouseUpp = mouse1;
    mouseDown = mouse3;
    mouseRight = mouse5;
    mouseLeft = mouse7;
    mouseUppLeft = mouse9;
    mouseUppRight = mouse11;
    mouseDownRight = mouse13;
    mouseDownLeft = mouse15;
    draw++;
  }
  else if (draw <10)
  {
    mouseUpp = mouse2;
    mouseDown = mouse4;
    mouseRight = mouse6;
    mouseLeft = mouse8;
    mouseUppLeft = mouse10;
    mouseUppRight = mouse12;
    mouseDownRight = mouse14;
    mouseDownLeft = mouse16;
    draw++;
  }
  else if (draw == 10)
  {
    draw = 0;
  }
 
  int mousey = Raylib.GetMouseY();
  int mousex = Raylib.GetMouseX();
  Vector3 xyDraw = mousepos(x,y,mousex,mousey,speed);
  float xf = xyDraw.X;
  float yf = xyDraw.Y;
  float drew = xyDraw.Z;
  x = (int) xf ;
  y = (int) yf ;
  Texture2D mouseDraw = MouseTexture(drew, mouseUpp, mouseDown, mouseRight, mouseLeft, theMouse, mouseUppLeft, mouseUppRight, mouseDownRight, mouseDownLeft);



  milliSecunds = milliSecund.ToString();
  seconds = second.ToString();
  minutes = minute.ToString();
  hours = hour.ToString();
  if (cheese)
  {
    points ++;
  }
  int yg = 0;
int xg = 0;
int wallx = 0;
    int wally = 0;
  //graphic
  Raylib.BeginDrawing();
   
  Raylib.ClearBackground(Color.BLACK);
  Raylib.DrawTexture(the_cheese_is_a_lie, 700, 400, Color.WHITE);
  for (int i = 0; i < 8; i++)
  {  
    for (int o = 0; o < 8; o++)
    {   int number = (int)grid5.GetValue(yg,xg);
      if (number==1) {Raylib.DrawTexture(wall1_1, wallx, wally, Color.WHITE);}
          xg++;
          wallx += 100;
  if (xg==8)
    {
        yg++;
        xg=0;
        wally += 100;
        wallx = 0; 
  }
  if (yg==8)
    {
        yg = 0;
        wally = 0;
  }}}
    
  Raylib.DrawTexture(mouseDraw, x, y, Color.WHITE);
  Raylib.DrawText(milliSecunds, 730, 10, 20, Color.WHITE);
  Raylib.DrawText(seconds, 700, 10, 20, Color.WHITE);
  Raylib.DrawText(minutes, 650, 10, 20, Color.WHITE);
  Raylib.DrawText(hours, 600, 10, 20, Color.WHITE);
  Raylib.EndDrawing();
}


static Vector3 mousepos(int x, int y, int mousex, int mousey, int speed){
  int draw = 0;

  if (mousey < y+19)
  {
    y-=speed;
    draw = 0;
    
  }
  if (mousey > y+31)
  {
    y+=speed;
    draw = 1;
  }
  if (mousex < x+19)
  {
    x-=speed;
    draw = 2; 
  }
  if (mousex > x+31)
  {
    x+=speed;
    draw = 3;
  }
  if (mousey < y+19&&mousex < x+19)
  {
    draw = 4;
  }
  if (mousey < y+19&&mousex > x+31)
  {
    draw = 5;
  }
  if (mousey > y+31&&mousex > x+31)
  {
    draw = 6;
  }
  if (mousey > y+31&&mousex < x+19)
  {
    draw = 7;
  }
  Vector3 mousexy = new Vector3(x,y,draw);
  return mousexy;
}
static Texture2D MouseTexture(float drew, Texture2D mouseUpp, Texture2D mouseDown, Texture2D mouseRight, Texture2D mouseLeft, Texture2D theMouse, Texture2D mouseUppLeft, Texture2D mouseUppRight, Texture2D mouseDownRight, Texture2D mouseDownLeft){
    if(drew == 0){
    theMouse = mouseUpp;
  }
  if(drew == 1){
    theMouse = mouseDown;
  }
    if(drew == 2){
    theMouse = mouseLeft;
  }
    if(drew == 3){
    theMouse = mouseRight;
  }
  if(drew == 4){
    theMouse = mouseUppLeft;
  }
  if(drew == 5){
    theMouse = mouseUppRight;
  }
  if (drew ==6){
    theMouse = mouseDownRight;
  }
  if(drew == 7){
    theMouse = mouseDownLeft;
  }
  return theMouse;
}
