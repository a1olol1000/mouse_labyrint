using Raylib_cs;
int screenHeight = 800;
int screenWith = 600;
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
Texture2D mouseUpp = mouse1;
Texture2D mouseDown = mouse3;
Texture2D mouseRight = mouse5;
Texture2D mouseLeft = mouse7;
Texture2D theMouse = mouse1;
Texture2D mouseUppLeft = mouse9;
Texture2D mouseUppRight = mouse11;
Texture2D mouseDownRight = mouse13;
Texture2D mouseDownLeft = mouse15; 
 Raylib.SetMousePosition(375, 275);
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
  if (mousey < y+25)

  if (mousey < y+19)
  {
    y-=speed;
    theMouse = mouseUpp;
    
  }
  if (mousey > y+31)
  {
    y+=speed;
    theMouse = mouseDown;
  }
  if (mousex < x+19)
  {
    x-=speed;
    theMouse = mouseLeft; 
  }
  if (mousex > x+31)
  {
    x+=speed;
    theMouse = mouseRight;
  }
  if (mousey < y+19&&mousex < x+19)
  {
    theMouse = mouseUppLeft;
  }
  if (mousey < y+19&&mousex > x+31)
  {
    theMouse = mouseUppRight;
  }
  if (mousey > y+31&&mousex > x+31)
  {
    theMouse = mouseDownRight;
  }
  if (mousey > y+31&&mousex < x+19)
  {
    theMouse = mouseDownLeft;
  }
  milliSecunds = milliSecund.ToString();
  seconds = second.ToString();
  minutes = minute.ToString();
  hours = hour.ToString();

  //graphic
  Raylib.BeginDrawing();
  
  Raylib.ClearBackground(Color.BLACK);
  
  Raylib.DrawTexture(theMouse, x, y, Color.WHITE);
  Raylib.DrawText(milliSecunds, 730, 10, 20, Color.WHITE);
  Raylib.DrawText(seconds, 700, 10, 20, Color.WHITE);
  Raylib.DrawText(minutes, 650, 10, 20, Color.WHITE);
  Raylib.DrawText(hours, 600, 10, 20, Color.WHITE);
  Raylib.EndDrawing();
}