using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BasicSpaceDude
{
    class FloatyDude
    {
        // Class Variables
        private Vector2 _position;
        private Texture2D _art;
        private Vector2 _velocity;

        private float _rotation;
        private float _rotationSpeed;

        // Class Constructors
        public FloatyDude(Texture2D txr, Vector2 startPos, Vector2 startVel)
        {
            _position = startPos;
            _velocity = startVel;
            _art = txr;

            _rotation = 0;
            _rotationSpeed = _velocity.Length() / 16;
        }

        // Class Methods
        public void UpdateMe(Rectangle bounds)
        {
            _position += _velocity;
            _rotation += _rotationSpeed;

            if (_position.X < bounds.Left || _position.X > bounds.Right)
                _velocity.X *= -1;

            if (_position.Y < bounds.Top || _position.Y > bounds.Bottom)
                _velocity.Y *= -1;
        }

        public void DrawMe(SpriteBatch sBatch)
        {
            // sBatch.Draw(Art, Position, Color.White);
            sBatch.Draw(_art, _position, null, Color.White, _rotation, _art.Bounds.Center.ToVector2(), 1, SpriteEffects.None, 0);
        }

    }
}
