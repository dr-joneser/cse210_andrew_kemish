using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;
using Raylib_cs;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                //HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
                LeaveTail(cast);
            }
        }

            // Call the GrowTail() function from snake based on an interval of time using raylib.GetTime()
        private void LeaveTail (Cast cast) {
            // Getting time since game window is opened in seconds and converting to float.
            float timePast = (float)Raylib.GetTime();
            // get snake and player2 from the cast and set the interval to grow
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Snake snake2 = (Snake)cast.GetFirstActor("PlayerTwo");
            int interval = 1;
            // When the rounded timePast is divisible by 2 then call the GrowTail() function
                if (Math.Round(timePast) % 2 == 0) {
                    snake2.GrowTail(interval);
                    snake.GrowTail(interval);
                }
            }
        

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Score score = (Score)cast.GetFirstActor("score");
            Food food = (Food)cast.GetFirstActor("food");
            
            if (snake.GetHead().GetPosition().Equals(food.GetPosition()))
            {
                int points = food.GetPoints();
                snake.GrowTail(points);
                score.AddPoints(points);
                food.Reset();
            }
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Actor head = snake.GetHead();
            List<Actor> body = snake.GetBody();
            Snake snake2 = (Snake)cast.GetFirstActor("PlayerTwo");
            Actor head2 = snake2.GetHead();
            List<Actor> body2 = snake2.GetBody();

            // Check for collisions within the first snake and its head
            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    isGameOver = true;
                }
            }
            // Check for collisions within snake2 and its head
            foreach (Actor segment in body2)
            {
                if (segment.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver = true;
                }
            }
            // Check for collisions between snake1 body and snake 2 head
            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver = true;
                }
            }
            // Check for collisions between snake2 body and snake 1 head
            foreach (Actor segment in body2)
            {
                if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    isGameOver = true;
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                Snake snake = (Snake)cast.GetFirstActor("snake");
                Snake snake2 = (Snake)cast.GetFirstActor("PlayerTwo");
                List<Actor> segments = snake.GetSegments();
                List<Actor> segments2 = snake2.GetSegments();
                Food food = (Food)cast.GetFirstActor("food");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white in snake 1
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.WHITE);
                }
                // make everything white in snake 2
                foreach (Actor segment in segments2)
                {
                    segment.SetColor(Constants.WHITE);
                }
                food.SetColor(Constants.WHITE);
            }
        }

    }
}