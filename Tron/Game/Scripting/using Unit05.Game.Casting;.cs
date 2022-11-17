// using Unit05.Game.Casting;
// using Unit05.Game.Services;


// namespace Unit05.Game.Scripting
// {
//     /// <summary>
//     /// <para>An input action that controls the snake.</para>
//     /// <para>
//     /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
//     /// </para>
//     /// </summary>
//     public class ControlActorsAction : Action
//     {
//         private KeyboardService keyboardService;
//         private Point direction = new Point(Constants.CELL_SIZE, 0);
//         private Point direction2 = new Point(Constants.CELL_SIZE, 0);

//         /// <summary>
//         /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
//         /// </summary>
//         public ControlActorsAction(KeyboardService keyboardService)
//         {
//             this.keyboardService = keyboardService;
//         }

//         /// <inheritdoc/>
//         public void Execute(Cast cast, Script script)
//         {
//             // left
//             if (keyboardService.IsKeyDown("a"))
//             {
//                 direction = new Point(-Constants.CELL_SIZE, 0);
//             }

//             // right
//             if (keyboardService.IsKeyDown("d"))
//             {
//                 direction = new Point(Constants.CELL_SIZE, 0);
//             }

//             // up
//             if (keyboardService.IsKeyDown("w"))
//             {
//                 direction = new Point(0, -Constants.CELL_SIZE);
//             }

//             // down
//             if (keyboardService.IsKeyDown("s"))
//             {
//                 direction = new Point(0, Constants.CELL_SIZE);
//             }
//             // PLAYER 2
//             // left
//             if (keyboardService.IsKeyDown("j"))
//             {
//                 direction2 = new Point(-Constants.CELL_SIZE, 0);
//             }

//             // right
//             if (keyboardService.IsKeyDown("l"))
//             {
//                 direction2 = new Point(Constants.CELL_SIZE, 0);
//             }

//             // up
//             if (keyboardService.IsKeyDown("i"))
//             {
//                 direction2 = new Point(0, -Constants.CELL_SIZE);
//             }

//             // down
//             if (keyboardService.IsKeyDown("k"))
//             {
//                 direction2 = new Point(0, Constants.CELL_SIZE);
//             }

//             Snake snake = (Snake)cast.GetFirstActor("snake");
//             snake.TurnHead(direction);

//             Snake snake2 = (Snake)cast.GetFirstActor("PlayerTwo");
//             snake2.TurnHead(direction2);

//         }
//     }
// }


// // using System.Collections.Generic;
// // using Unit05.Game.Casting;
// // using Unit05.Game.Services;


// // namespace Unit05.Game.Scripting
// // {
// //     /// <summary>
// //     /// <para>An output action that draws all the actors.</para>
// //     /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
// //     /// </summary>
// //     public class DrawActorsAction : Action
// //     {
// //         private VideoService videoService;

// //         /// <summary>
// //         /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
// //         /// </summary>
// //         public DrawActorsAction(VideoService videoService)
// //         {
// //             this.videoService = videoService;
// //         }

// //         /// <inheritdoc/>
// //         public void Execute(Cast cast, Script script)
// //         {
// //             Snake snake = (Snake)cast.GetFirstActor("snake");
// //             List<Actor> segments = snake.GetSegments();
// //             Actor score = cast.GetFirstActor("score");
// //             Actor food = cast.GetFirstActor("food");
// //             List<Actor> messages = cast.GetActors("messages");

// //             Snake snake2 = (Snake)cast.GetFirstActor("PlayerTwo");
// //             List<Actor> segments2 = snake2.GetSegments();
// //             Actor score2 = cast.GetFirstActor("score");
// //             Actor food2 = cast.GetFirstActor("food");
            
// //             videoService.ClearBuffer();
// //             videoService.DrawActors(segments);
// //             videoService.DrawActor(score);
// //             videoService.DrawActor(food);

// //             videoService.ClearBuffer();
// //             videoService.DrawActors(segments2);
// //             videoService.DrawActor(score2);
// //             videoService.DrawActor(food2);
// //             videoService.DrawActors(messages);
// //             videoService.FlushBuffer();
// //         }
// //     }
// // }