using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1
{

    public class RunningInPlaceMarioSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        public Vector2 Start { get; set; }
        public Vector2 End { get; set; }
        public Vector2 Offset { get; set; }
        private Vector2 unitOffset;
        private Vector2 currentOffset;
        public int TotalFrames { get; set; }
        private int width;
        private int height;
        private int currentFrame;

        public RunningInPlaceMarioSprite(Texture2D texture, Vector2 start, Vector2 end, int frames, Vector2 offset)
        {
            Texture = texture;
            Start = start;
            End = end;
            TotalFrames = frames;
            Offset = offset;
            unitOffset.X = offset.X/frames;
            unitOffset.Y = offset.Y/frames;
            currentFrame = 0;
            width = (int) (End.X - Start.X)/frames;
            height = (int) (End.Y - Start.Y);
            currentOffset.X = 0;
            currentOffset.Y = 0;
        }

        public void Update()
        {
            currentFrame++;
            currentOffset += unitOffset;
            if (currentFrame == TotalFrames)
            {
                currentFrame = 0;
                currentOffset.X = 0;
                currentOffset.Y = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            location += currentOffset;
            Rectangle sourceRectangle = new Rectangle((int) Start.X + width*currentFrame, (int) Start.Y,
                width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }

    public class DeadMovingUpAndDownMarioSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        public Vector2 Start { get; set; }
        public Vector2 End { get; set; }
        public Vector2 Offset { get; set; }
        private Vector2 unitOffset;
        private Vector2 currentOffset;
        public int TotalFrames { get; set; }
        private int width;
        private int height;
        private int currentFrame;

        public DeadMovingUpAndDownMarioSprite(Texture2D texture, Vector2 start, Vector2 end, int frames, Vector2 offset)
        {
            Texture = texture;
            Start = start;
            End = end;
            TotalFrames = frames;
            Offset = offset;
            unitOffset.X = offset.X/frames;
            unitOffset.Y = offset.Y/frames;
            currentFrame = 0;
            width = (int) (End.X - Start.X)/frames;
            height = (int) (End.Y - Start.Y);
            currentOffset.X = 0;
            currentOffset.Y = 0;
        }

        public void Update()
        {
            currentFrame++;
            currentOffset += unitOffset;
            if (currentFrame == TotalFrames)
            {
                currentFrame = 0;
                currentOffset.X = 0;
                currentOffset.Y = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            location += currentOffset;
            Rectangle sourceRectangle = new Rectangle((int) Start.X + width*currentFrame, (int) Start.Y,
                width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }

    public class RunningLeftAndRightMarioSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        public Vector2 Start { get; set; }
        public Vector2 End { get; set; }
        public Vector2 Offset { get; set; }
        private Vector2 unitOffset;
        private Vector2 currentOffset;
        public int TotalFrames { get; set; }
        private int width;
        private int height;
        private int currentFrame;

        public RunningLeftAndRightMarioSprite(Texture2D texture, Vector2 start, Vector2 end, int frames, Vector2 offset)
        {
            Texture = texture;
            Start = start;
            End = end;
            TotalFrames = frames;
            Offset = offset;
            unitOffset.X = offset.X/frames;
            unitOffset.Y = offset.Y/frames;
            currentFrame = 0;
            width = (int) (End.X - Start.X)/frames;
            height = (int) (End.Y - Start.Y);
            currentOffset.X = 0;
            currentOffset.Y = 0;
        }

        public void Update()
        {
            currentFrame++;
            currentOffset += unitOffset;
            if (currentFrame == TotalFrames)
            {
                currentFrame = 0;
                currentOffset.X = 0;
                currentOffset.Y = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            location += currentOffset;
            Rectangle sourceRectangle = new Rectangle((int) Start.X + width*currentFrame, (int) Start.Y,
                width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
