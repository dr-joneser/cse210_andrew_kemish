abstract class Position {
    // CONTAINS THE X AND Y COORDINATES FOR ALL OBJECTS THAT WILL BE ON SCREEN
    public int xPosition = new int();
    public int yPosition = new int();
}

abstract class MovementHorizontal: Position {
    // X-VALUE POSITION OF PLAYER IS CHANGED WHEN LEFT OR RIGHT ARROW KEYS ARE PRESSED
}

abstract class MovementVertical: Position {
    // Y-VALUE POSITION OF ROCKS AND GEMS ARE INCREASING AT A CONSTANT RATE (GRAVITY)
}