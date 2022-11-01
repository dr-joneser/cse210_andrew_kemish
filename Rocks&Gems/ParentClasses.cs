abstract class Position {
    // CONTAINS THE X AND Y COORDINATES FOR ALL OBJECTS THAT WILL BE ON SCREEN
    public int xPos = new int();
    public int yPos = new int();
}

abstract class MovementHorizontal: Position {
    // X-VALUE POSITION OF PLAYER IS CHANGED WHEN LEFT OR RIGHT ARROW KEYS ARE PRESSED
    //
    //if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
    //     PlayerRectangle.x += MovementSpeed;
    //}
    //
    //if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
    //     PlayerRectangle.x -= MovementSpeed;
    //}

}

abstract class MovementVertical: Position {
    // Y-VALUE POSITION OF ROCKS AND GEMS ARE INCREASING AT A CONSTANT RATE (GRAVITY)
}